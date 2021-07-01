﻿using Gighub.Models;
using Gighub.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace Gighub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public GigsController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Create()
        {
            var viewModel = new GigFormVm
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }
    }
}