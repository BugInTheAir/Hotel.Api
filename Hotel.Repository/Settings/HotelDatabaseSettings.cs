namespace Hotel.Repository.Settings
{
    public class HotelDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string RoomsCollectionName { get; set; } = null!;
    }
}
