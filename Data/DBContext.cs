
using Job_Application_Tracker.Models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace Job_Application_Tracker.Data
{
    
    public class DBContext : DbContext
    {
        
        public DBContext (DbContextOptions<DBContext> options) : base(options)
        {
            



        }

        
        
        public DbSet<JobApplication> JobApplications {get; set;}

        



    }




}



