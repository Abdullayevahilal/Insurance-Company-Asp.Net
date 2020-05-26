using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.PageRepository;

namespace Insurance_Company.Controllers
{
    public class PagesController : Controller
    {
        private readonly IPageRepository _pageRepository;
        private readonly IMapper _mapper;
        public PagesController(IPageRepository pageRepository, IMapper mapper)
        {
            _mapper = mapper;
            _pageRepository = pageRepository;
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }
    }
}