using minifica.data.IRepository;
using minifica.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minifica.data.Repository
{
	public class BaseRepository<E> : IBaseRepository<E> where E : class
	{
		public readonly MinificaContext _context;

		public BaseRepository(MinificaContext context)
		{
			_context = context;
		}

		public void Add(E entity)
		{
			_context.Set<E>().Add(entity);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			var entity = this.GetById(id);
			_context.Set<E>().Remove(entity);
			_context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
		}

		public List<E> GetAll()
		{
			return _context.Set<E>().ToList();
		}

		public E GetById(int id)
		{
			return _context.Set<E>().Find(id);
		}

		public void Update(E entity)
		{
			_context.Set<E>().Update(entity);
			_context.SaveChanges();
		}
	}
}
