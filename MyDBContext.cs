using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Assignment3.Models;

namespace Assignment3.Models
{
 

    public class MyDBContext :DbContext
    {
        public MyDBContext()
         : base("name=conn")
        {

        }
        public DbSet<User> Users { get; set; }

    }
}