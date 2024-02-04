using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento
{
    public class DB : DbContext
    {
        public DB() : base("name=SistemaEstacionamentoDB") { }

        [Table("Transacoes")]
        public class Transacao
        {
            public int Id { get; set; }
            [MaxLength(8)]
            public string Placa { get; set; }
            public string Fabricante { get; set; }
            public int NumVaga { get; set; }
            [MaxLength(20)]
            public string MetodoPagamento { get; set; }
            public DateTime DataEntrada { get; set; }
            public DateTime? DataSaida { get; set; }
            public double? Valor { get; set; }
        }

        public DbSet<Transacao> Transacoes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DB>());
            base.OnModelCreating(modelBuilder);
        }

    }
}
