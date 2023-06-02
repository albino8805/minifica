using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minifica.data.IRepository
{
	public interface IBaseRepository<E> : IDisposable where E : class
	{
		List<E> GetAll();
		E GetById(int id);
		void Add(E entity);
		void Update(E entity);
		void Delete(int id);
	}
}
