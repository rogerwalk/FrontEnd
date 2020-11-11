using Microsoft.EntityFrameworkCore;
using Solution.DO.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.DAL.EF
{
   public class SolutionDBContext : DbContext
    {

        //Constructor para la conexion con la base de datos mediante DbContext
        public SolutionDBContext (DbContextOptions<SolutionDBContext>options) : base(options)
            {
             



        }

        public DbSet<Cafe> Cafe { get; set; }
        public DbSet<Productor> Productor { get; set; }
        public DbSet<Marcas> Marcas { get; set; }
      

    }
}
