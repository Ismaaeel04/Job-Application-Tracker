
using Job_Application_Tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace Job_Application_Tracker.Data
{
    
    public class DBContext : DbContext
    {
        
        public DBContext (DbContextOptions<DBContext> options) : base(options)
        {
            
            
            


        }


    }




}



