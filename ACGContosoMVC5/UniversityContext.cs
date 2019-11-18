﻿using ACG_ContosoMVC5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ACGContosoMVC5
{
    public class UniversityContext: DbSet
    {

         public UniversityContext() : base("UniversityContext")
         {

         }

         public DbSet<Student> Students { get; set; }
         public DbSet<Enrollment> Enrollments { get; set; }
         public DbSet<Course> Courses { get; set; }

         protected override void OnModelCreating(DbModelBuilder modelBuilder)
         {
          // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
         }

    } 
}