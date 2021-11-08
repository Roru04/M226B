using System;
using System.Collections.Generic;
using System.Text;

namespace CarSales
{
    class Person : BaseModel, IManagebleEntity
    {
        public object Parent { get; set; }
        public IEnumerable<object> Childern { get ; set; }

        public void AddCHildren()
        {
            throw new NotImplementedException();
        }

        public void SetParent()
        {
            throw new NotImplementedException();
        }
    }
}
