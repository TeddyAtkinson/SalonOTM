using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists //creates list of stylists thats equal to the database results of stylists
                           .Include(stylist => stylist.clients)  //includes
                           .ToList();
      return View(model);
    }
  }
}