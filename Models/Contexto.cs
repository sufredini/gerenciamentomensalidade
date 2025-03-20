using Microsoft.EntityFrameworkCore;

namespace GerenciamentoMensalidade.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Alunos> Alunos { get; set; }

        public DbSet<Plano> Plano { get; set; }


    }
}
