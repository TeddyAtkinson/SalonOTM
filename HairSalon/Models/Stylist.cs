namespace Salon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Name { get; set; }
    public int ClientId { get; set; }
    public Client Client { get; set; }
  }
}