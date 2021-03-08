namespace DataLibrary.Repositories
{
   public interface IUpdate<T>
    {
        T Update(T model);
    }
}