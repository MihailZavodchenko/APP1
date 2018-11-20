using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP1
{
 /// <summary>
 /// Класс описывает одно измерение
 /// </summary>
    class measurement
    {
        int step; //шаг
        double amplitude;// амплитуда (вольты)

        /// <summary>
        /// Инициализирует новый экземпляр класса
        /// </summary>
        /// <param name="step">шаг на котором сделано измерение</param>
        /// <param name="amplitude"> значение амплитуды</param>
        public measurement(int step, double amplitude)
        {
            this.step = step;
            this.amplitude = amplitude;
        }

        public measurement()
        {
        }

    }
}
