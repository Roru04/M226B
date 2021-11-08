using System;
using System.Collections.Generic;
using System.Text;

namespace CarSales
{
    class CarType : BaseModel, ICarType
    {
        public object GetCarType { get ; set ; }

        public string Name { get; set; }


    }
}
