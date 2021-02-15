using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes {
    class Sqr {

        public int Side1 { get; set; }

        public int GetPerimeter() {
            return 4 * Side1;
        }

        public int GetArea() {
            return Side1 * Side1;
        }

        public Sqr() {

        }

        public Sqr(int s1) {
            Side1 = s1;
        }

    }
}
