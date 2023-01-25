using BEComentarios.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEComentarios
{
    public class AplicationDBContext: DbContext
    {
        public DbSet<Comentario> Comentarios { get; set; }
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options): base(options)
        {

        }
    }
}
