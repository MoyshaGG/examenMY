using System;
using System.Collections.Generic;
using System.Text;

namespace examsss
{
    class TriangleSteal : PowerSteal
    {
        private int katet1;
        private int katet2;
        public TriangleSteal(int thickness, double density, int katet1,int katet2) : base(thickness, density)
        {
            this.katet1 = katet1;
            this.katet2 = katet2;

        }

        public override double Square()
        {
            return (katet1 * katet2)/2;
        }
        public override double Weight()
        {
            return base.Weight();
        }
        public override string Information()
        {
            return "Трикутний лист: Товщина - " + thickness + " густина:" + density;
        }


    }
}
