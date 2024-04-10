using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {

        public static IDataAccess GetDataAccessType(string databaseType)
        {
            if(databaseType == "sql")
            {
                return new SQLDataAccess();
            }
            else if(databaseType == "mongo")
            {
                return new MongoDataAccess();
            }
            else if (databaseType == "list")
            {
                return new ListDataAccess();
            }
            else
            {
                return null;
            }
        }

    }
}
