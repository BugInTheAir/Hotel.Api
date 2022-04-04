namespace FruitsShop.Repository.Settings
{
    public class DatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string FruitsCollectionName { get; set; } = null!;
    }
}
