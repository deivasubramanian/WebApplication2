namespace DataLibrary.Repositories
{
   public interface IDelete<Id, Query>
    {
        bool Delete(Id id);
        bool Delete(Query query);
        bool DeleteMany(Query query);
    }
}