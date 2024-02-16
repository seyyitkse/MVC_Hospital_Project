using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Context:DbContext
    {
        public DbSet<Heading> Headings { get; set; }
        public DbSet<HeadingInfo> HeadingInfos { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Secretary> Secretaries { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
