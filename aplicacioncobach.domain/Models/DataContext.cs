namespace aplicacioncobach.domain.Models
{
    using System.Data.Entity;
    public class DataContext :DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<aplicacioncobach.common.models.Products> Products { get; set; }
    }
}
