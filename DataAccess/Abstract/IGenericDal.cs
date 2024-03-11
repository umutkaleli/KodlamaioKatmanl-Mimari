using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IGenericDal<T>
{
    void Add(T entity);
    T Delete(T entity);
    T Update(T entity);
    List<T> GetAll();
}