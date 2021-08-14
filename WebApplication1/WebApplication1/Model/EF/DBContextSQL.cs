namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContextSQL : DbContext
    {
        public DBContextSQL()
            : base("name=DBContextSQL")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.typeUser)
                .IsUnicode(false);
        }
    }
}
