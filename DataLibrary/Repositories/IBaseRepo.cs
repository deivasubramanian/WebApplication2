namespace DataLibrary.Repositories
{
  public interface IBaseRepo<Type, Id, Query> :     
    IAdd<Type>,
    IUpdate<Type>,
    IGet<Type, Id, Query>,
    IDelete<Id, Query> {}
}