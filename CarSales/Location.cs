using System;
using System.Collections.Generic;
using System.Text;

namespace CarSales
{
    class Location : BaseModel, ILocation
    {
        public string Name { get; set ; }
        public object Parent { get; set ; }
        public IEnumerable<IManagebleEntity> Childern { get ; set ; }

        public Location()
        {

        }

        void AvailableCars()
        {

        }

        void PrintStatistics()
        {

        }

        public void AddCHildren()
        {
            throw new NotImplementedException();
        }

        public void GetAvailableVehicel()
        {
            throw new NotImplementedException();
        }

        public void GetFreeSalesManager()
        {
            throw new NotImplementedException();
        }

        public void SetParent()
        {
            throw new NotImplementedException();
        }

        public void Visit()
        {
            throw new NotImplementedException();
        }
    }
}
