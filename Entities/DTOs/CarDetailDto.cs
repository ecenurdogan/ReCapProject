﻿using Core.Enitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int DailyPrice { get; set; }
    }
}
