using CCD_Attendance.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CCD_Attendance.Data
{
    public class ccdDBContext : IdentityDbContext<IdentityUser>
    {
        public ccdDBContext(DbContextOptions<ccdDBContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            

        }



    }
}
