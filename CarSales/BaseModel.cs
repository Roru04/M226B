﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarSales
{
    abstract class BaseModel : IBaseModel
    {
        public int Id { get; set; }

        public string Text { get; set; }
    }
}
