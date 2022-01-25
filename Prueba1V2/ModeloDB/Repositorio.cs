using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore.tools;

namespace ModeloDB
{
    public class Repositorio : DbContext
    {
        public DbSet<address> address { get; set; }
        public DbSet<payment> payment { get; set; }
        public DbSet<staff> staff { get; set; }

        //Configuracion de la conexion
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=MIPCC\\STALINSQL; Initial Catalog=store; trusted_connection=true;");


        }
    }
}
