using System;

using System.Collections.Generic;
using System.Text;

namespace CarSales
{
    interface IManagebleEntity
    {
        public object Parent { get; set; }

        public IEnumerable<object> Childern { get; set; }


        public void AddCHildren();

        public void SetParent();

     

    }
}
