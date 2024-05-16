using System.Data.Entity;

namespace Blog.DAO
{
    public class Dao
    {
        protected ApplicationDBContext dbContext;
        public Dao ()
        {
            dbContext = new ApplicationDBContext ();
        }



    }
}
