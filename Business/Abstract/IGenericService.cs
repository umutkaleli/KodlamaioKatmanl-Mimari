namespace Business.Abstract;

public interface IGenericService<T> 
{
    void Add(T entity);
    T Delete(T entity);
    T Update(T entity);
    List<T> GetAll();
}