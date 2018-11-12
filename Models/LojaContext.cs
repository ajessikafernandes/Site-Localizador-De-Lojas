using System;
using Microsoft.EntityFrameworkCore;

namespace LojasCRUD.Models{
    public class LojaContext : DbContext{
        public LojaContext(DbContextOptions<LojaContext> options) : base(options){
            //Default
        }

        public DbSet<Loja> Lojas{get; set; } 
    }
}