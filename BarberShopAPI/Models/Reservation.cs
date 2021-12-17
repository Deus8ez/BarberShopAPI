namespace BarberShopAPI.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int BarberId { get; set; }
        public Barber Barber { get; set; }
        public string ClientName { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public string Date { get; set; }
    }
}
