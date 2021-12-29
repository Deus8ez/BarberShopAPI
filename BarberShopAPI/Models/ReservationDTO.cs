namespace BarberShopAPI.Models
{
    public class ReservationDTO
    {
        public int BarberId { get; set; }
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public int ServiceId { get; set; }
        public string Date { get; set; }
    }
}
