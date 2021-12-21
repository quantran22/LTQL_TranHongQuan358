using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQL_1721050358.Models
{
    public partial class LTQLBbContex : DbContext
    {
        public LTQLBbContex()
            : base("name=LTQLBbContex")
        {
        }

        public virtual DbSet<LopHoc358> LopHoc358s { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
