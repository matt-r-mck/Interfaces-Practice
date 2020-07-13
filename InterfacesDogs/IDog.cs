using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDogs {
    interface IDog {

        public string Name { get; set; }
        public string Color { get; set; }
        public string BarkSound { get; set; }

        public void Bark(); //signature for instance method


    }
}
