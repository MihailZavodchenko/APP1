using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP1
{
    //описывает одно измерение
    class measurement
    {
        int step; //шаг
        double amplitude;// амплитуда (вольты)

        public measurement(int step, double amplitude)
        {
            this.step = step;
            this.amplitude = amplitude;
        }
    }
}
