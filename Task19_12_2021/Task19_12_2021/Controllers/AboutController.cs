using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task19_12_2021.Data;
using Task19_12_2021.Models;

namespace Task19_12_2021.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Our_team> our_Teams = _context.Our_Teams.Include("Specialty").ToList();
            return View(our_Teams);
        }
    }
}
