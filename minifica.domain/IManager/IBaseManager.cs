using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minifica.domain.IManager
{
	public interface IBaseManager<VM, E> where VM : class where E : class
	{
		List<VM> GetAll();
		VM GetById(int id);
		VM Add(VM state);
		void Update(int id, VM state);
		void Delete(int id);
	}
}
