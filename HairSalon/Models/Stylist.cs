using System;

namespace Salon.Models
{
  public class Stylist
  {
    public int stylist_id { get; set; }
    public string stylist_name { get; set; }
    public Client clients { get; set; }
  }
}