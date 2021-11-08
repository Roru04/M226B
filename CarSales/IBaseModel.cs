using System;
using System.Collections.Generic;
using System.Text;

namespace CarSales
{
    interface IBaseModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
