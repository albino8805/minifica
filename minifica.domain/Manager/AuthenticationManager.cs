using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using minifica.data.IRepository;
using minifica.data.Repository;
using minifica.data.ViewModels;
using minifica.domain.Helpers;
using minifica.domain.IManager;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace minifica.domain.Manager
{
	public class AuthenticationManager : IAuthenticationManager
	{
		private IUserRepository _userRepository;
		readonly JwtSetting _jwtSetting;

		public AuthenticationManager(IOptions<JwtSetting> options, IUserRepository userRepository)
		{
			_jwtSetting = options.Value;
			_userRepository = userRepository;
		}

		public LoginViewModel ValidateUser(AuthenticationViewModel authentication)
		{
			var user = _userRepository.GetByEmail(authentication.Email);

			if(user == null)
			{
				throw new Exception("El usuario no existe");
			}

			if(user.Password != authentication.Password)
			{
				throw new Exception("Credenciales invalidas");
			}

			LoginViewModel login = new LoginViewModel
			{
				User = new UserViewModel(){
					Id = user.Id,
					Name = user.Name,
					LastName = user.LastName,
					Phone = user.Phone,
					Email = user.Email
				},
				Token = GenJwt(user.Id.ToString(), null)
			};

			return login;
		}

		private string GenJwt(string id, List<Claim> extraClaims = null)
		{
			byte[] key = Encoding.ASCII.GetBytes(_jwtSetting.Secret);
			var timeLifeInDays = _jwtSetting.TimeLifeInDays;

			JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
			List<Claim> subjetClaims = new List<Claim> {
				new Claim(ClaimTypes.Sid, id),
				new Claim(ClaimTypes.System, "MINIFICA" )
			};

			if (extraClaims != null && extraClaims.Count > 0)
				subjetClaims.AddRange(extraClaims);

			var issuedAt = DateTime.UtcNow;

			SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
			{
				Audience = "MINIFICA",
				Expires = issuedAt.AddDays(timeLifeInDays),
				IssuedAt = issuedAt,
				Subject = new ClaimsIdentity(subjetClaims),
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
			};
			SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
			string tokenString = tokenHandler.WriteToken(token);
			return tokenString;
		}
	}
}
