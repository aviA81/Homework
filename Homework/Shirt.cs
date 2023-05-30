using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks {
    enum Colors {
        red,
        green,
        blue
    }
    enum Designs {
        striped,
        checkered,
        plain
    }
    internal class Shirt {
        public Colors Colors { get; set; }
        public Designs Designs { get; set; }

        public Shirt(Colors colors, Designs designs) {
            Colors = colors;
            Designs = designs;
        }

        public override string? ToString() {
            return $"a {Colors} {Designs} shirt";
        }
    }
}
