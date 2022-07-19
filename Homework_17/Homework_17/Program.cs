using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_17
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationContext(@"Data Source=.\SQLEXPRESS;Initial Catalog = Homework;Integrated Security=True;"))
            {
                context.Database.EnsureCreated();                
            }
        }
    }
}
