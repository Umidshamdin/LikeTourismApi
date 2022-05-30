﻿using ServiceLayer.DTOs.Slider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ISliderService
    {

        Task<List<SliderDto>> GetAllAsync();

        Task InsertAsync(SliderCreateDto slider);


    }
}
