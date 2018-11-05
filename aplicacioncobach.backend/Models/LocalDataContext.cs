
namespace aplicacioncobach.backend.Models
{
    using domain.Models;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<aplicacioncobach.common.models.Products> Products { get; set; }
    }
}