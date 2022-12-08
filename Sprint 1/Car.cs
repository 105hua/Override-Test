using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_1
{

    class Car
    {

        public string manufacturer { get; set; }
        public string make { get; set; }

        public Car()
        {

            manufacturer = "N/A";
            make = "N/A";

        }

        public Car(string manufacturer, string make)
        {
            this.manufacturer = manufacturer;
            this.make = make;
        }

        public override string ToString()
        {

            return manufacturer + " | " + make;

        }

    }

}
