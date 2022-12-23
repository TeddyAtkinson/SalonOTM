using System;
using System.Collections.Generic;

namespace Salon.Models
{
  public class Client
  {
    public int client_id { get; set; }
    public string client_name { get; set; }
    public List<Client> Clients { get; set; }
  }
}