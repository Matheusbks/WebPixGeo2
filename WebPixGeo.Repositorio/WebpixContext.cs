using Microsoft.EntityFrameworkCore;
using WebPixGeo.Entidade;

namespace WebPixGeo.Repositorio
{
    public class WebpixContext : DbContext
    {
        public DbSet<Endereco> Endereco { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(@"Server=DESKTOP-9B04LJT\SQLEXPRESS;Database=WebPixPrincipal;Trusted_Connection=True;Integrated Security = True;");
            optionsBuilder.UseSqlServer(@"Data Source=34.226.175.244;Initial Catalog=WebPixGeo;Persist Security Info=True;User ID=sa;Password=StaffPro@123;");
        }


    }
}
