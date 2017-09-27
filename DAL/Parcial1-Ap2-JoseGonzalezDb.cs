using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;

namespace DAL
{
    class Parcial1_Ap2_JoseGonzalezDb : DbContext
    {
        public Parcial1_Ap2_JoseGonzalezDb() : base("ConStr")
        {

        }

        public virtual DbSet<Presupuestos> Presupuestos { get; set; }

    }
}
