﻿using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Server.models;

namespace Server.DAL
{
    public class AttendanceSystemContext:DbContext
    {
        public AttendanceSystemContext(DbContextOptions<AttendanceSystemContext>option):base(option) { }
         
        public DbSet<Employee> Employees { get; set; }

    }
}
