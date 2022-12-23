using System;

namespace Salon.Models
{
  public class Stylist
  {
    public int stylist_id { get; set; }
    public string Description { get; set; }
    public int client_id { get; set; }
    public Stylist Stylists { get; set; }
  }
}