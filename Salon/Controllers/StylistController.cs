using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Salon.Models;

namespace Salon.Controllers
{
  public class StylistController : Controller
  {
    private readonly SalonContext _db;

    public StylistController(SalonContext db)
    {
      _db = db;
    }
  }
}