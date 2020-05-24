using AutoMapper;
using Insurance_Company.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.HomeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Insurance_Company.ViewComponents
{
    public class SliderViewComponent :ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IHomeRepository _homeRepository;



        public SliderViewComponent(IMapper mapper,
                                         IHomeRepository homeRepository)
        {
            _mapper = mapper;
            _homeRepository = homeRepository;
            
        }
        public IViewComponentResult Invoke()
        {
            var slide = _homeRepository.GetHomeSliders();

            var model = _mapper.Map<IEnumerable<HomeSlider>, IEnumerable<SliderViewModel>>(slide);

            return View(model);
        }
    }


}
