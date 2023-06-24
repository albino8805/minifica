using minifica.data.Models;

namespace minifica.data.IRepository
{
    public interface IUserRepository: IBaseRepository<User>
    {
		User GetByEmail(string email);

	}
}
