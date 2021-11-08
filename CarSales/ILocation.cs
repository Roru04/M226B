using System;
using System.Collections.Generic;
using System.Text;

namespace CarSales
{
    interface ILocation : IManagebleEntity
    {
        public string Name { get; set; }

        public void GetAvailableVehicel();

        public void GetFreeSalesManager();

        public void Visit();
    }
}
