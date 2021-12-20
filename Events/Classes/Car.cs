using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events.EventArgs;
using Events.Interfaces;

namespace Events.Classes
{
    public class Car : ICar
    {
        public event EventHandler<CarEventArgs> Drive;

        public double HorsePower { get; set; }

        public Car(double horsepower)
        {
            HorsePower = horsepower;
        }

       

        public void StepOnGas()
        {
            onDrive(new CarEventArgs()
            {
                HP = HorsePower
            });
        }

        public virtual void onDrive(CarEventArgs e)
        {
            Drive?.Invoke(this, e);
        }
    }
}
