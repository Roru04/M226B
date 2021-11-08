using System;
using System.Collections.Generic;
using System.Text;

namespace CarSales
{
    class Vehicle : BaseModel, IManagebleEntity
    {
        public string Brand { get; set; }

        public Location Location { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }
        public object Parent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<object> Childern { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Vehicle()
        {

        }

        public void AddCHildren()
        {
            throw new NotImplementedException();
        }

        public void SetParent()
        {
            throw new NotImplementedException();
        }

        void Drive()
        {

        }

        void IsAvailible()
        {

        }

        void Reserve()
        {

        }


    }
}
