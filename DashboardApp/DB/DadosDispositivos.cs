using System;
using Microsoft.EntityFrameworkCore;

namespace DashboardApp.DB
{
    public class DadosDispositivos
    {
        public int Id { get; set; } // Chave primária
        public string Area { get; set; }
        public int TotalDispositivos { get; set; }
        public int Operacional { get; set; }
        public int Inoperante { get; set; }
        public double PercentualOperante { get; set; }
        public double PercentualInoperante { get; set; }
    }

    public class MyDbContext : DbContext
    {
        public DbSet<DadosDispositivos> DadosDispositivos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=meuBancoDeDados.db");
        }
    }

    public class Program
    {
        public static void Main()
        {
            using (var context = new MyDbContext())
            {
                context.Database.EnsureCreated(); // Cria o banco de dados se ele não existir

                var dados = new DadosDispositivos
                {
                    Area = "Central",
                    TotalDispositivos = 290,
                    Operacional = 250,
                    Inoperante = 40,
                    PercentualOperante = 0.86,
                    PercentualInoperante = 0.14
                };
                var dados1 = new DadosDispositivos
                {
                    Area = "Cozinha",
                    TotalDispositivos = 30,
                    Operacional = 18,
                    Inoperante = 12,
                    PercentualOperante = 0.6,
                    PercentualInoperante = 0.4
                }; 
                var dados2 = new DadosDispositivos
                {
                    Area = "Oficina",
                    TotalDispositivos = 400,
                    Operacional = 243,
                    Inoperante = 157,
                    PercentualOperante = 0.61,
                    PercentualInoperante = 0.39
                };
                var dados3 = new DadosDispositivos
                {
                    Area = "Banheiros",
                    TotalDispositivos = 10,
                    Operacional = 2,
                    Inoperante = 8,
                    PercentualOperante = 0.2,
                    PercentualInoperante = 0.8
                };
                context.DadosDispositivos.Add(dados); // Adicione o primeiro objeto
                context.DadosDispositivos.Add(dados1); // Adicione o segundo objeto
                context.DadosDispositivos.Add(dados2);
                context.DadosDispositivos.Add(dados3);
                context.SaveChanges(); // Salve as mudanças no banco de dados
            }
        }
    }
}
