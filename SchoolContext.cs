using SchoolDb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFmodelCHECK.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("check")
        {

        }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassFurniture> ClassFurniture { get; set; }
        public DbSet<ClassSubjects> ClassSubjects { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Fees> Fees { get; set; }
        public DbSet<Marks> Marks { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<StaffAttendance> StaffAttendance { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAttendance> StudentAttendance { get; set; }
        public DbSet<Subject> Subjectss { get; set; }
        public DbSet<TimeTable> TimeTable { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<FurnitureRecord> FurnitureRecords { get; set; }
        public DbSet<FurnitureRemoved> FurnitureRemoved { get; set; }
        public DbSet<FurnitureRepaired> FurnitureRepaired { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


        }
    }
}
