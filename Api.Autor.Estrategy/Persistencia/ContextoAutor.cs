using Api.Autor.Estrategy.Modelo;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Api.Autor.Estrategy.Persistencia
{
    public class ContextoAutor : DbContext
    {
        public ContextoAutor(DbContextOptions<ContextoAutor> options) : base(options) { }

        //
        public DbSet<AutorLibro> AutorLibros { get; set; }

        public DbSet<GradoAcademico> GradosAcademicos { get; set; }
    }
}
