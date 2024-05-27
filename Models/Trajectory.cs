namespace FleetManagement.Models
{
    public class Trajectory
    {
        public int Id { get; set; }
        public int TaxiId { get; set; }
        public DateTime Date { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Taxi? Taxi { get; set; }
    }
}
