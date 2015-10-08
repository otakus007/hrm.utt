namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MenuDbContext : DbContext
    {
        public MenuDbContext()
            : base("name=MenuDbContext")
        {
        }

        public virtual DbSet<Menu> Menus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()
                .Property(e => e.Link)
                .IsUnicode(true);
        }
    }
}
