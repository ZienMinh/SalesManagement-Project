using BusinessObject;

namespace DataAccess
{
    public class EntityDAO
    {
        private static EntityDAO instance;
        public FStoreContext context;
        public EntityDAO()
        {
            context = new FStoreContext();
        }
        private static object lockObject = new object();
        public static EntityDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null) instance = new EntityDAO();
                }
                return instance;
            }
        }
    }
}
