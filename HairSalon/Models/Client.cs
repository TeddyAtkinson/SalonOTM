using System.Collections.Generic;

namespace Salon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public List<Stylist> Stylists { get; set; }
  }
}