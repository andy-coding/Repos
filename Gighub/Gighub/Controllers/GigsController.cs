using System;
using System.Collections.Generic;
using System.Linq;
using System.Web; 
using System.Web.Mvc;
using Gighub.Models;
using Gighub.ViewModels;

namespace Gighub.Controllers
{
    public class GigsController : Controller
    {
        private ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            { Genres = _context.Genres.ToList() };

            return View(viewModel);
        }
    }
}