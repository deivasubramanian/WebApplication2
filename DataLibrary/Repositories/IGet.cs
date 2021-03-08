using System.Collections.Generic;

namespace DataLibrary.Repositories
{
   public interface IGet<Type, Id, Query>
    {
        Type Get(Id id);
        Type Get(Query query);

        IEnumerable<Type> GetMany(Query query);
    }
}