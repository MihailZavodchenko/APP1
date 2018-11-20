using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP1
{
    /// <summary>
    /// Клас для данных
    /// </summary>
    class data
    {

        int direction; ///<summary>направление движение каретки 1 прямое -1 обратное </summary> 
        public List<measurement> measurements; //список измерений
        int angle; ///<summary>угол поворота проволоки</summary>

        /// <summary>
        /// Инициализация нового набора данных
        /// </summary>
        public data()
        {
            measurements = new List<measurement>();
        }
       
        /// <summary>
        /// Задает направление движения каретки
        /// </summary>
        /// <param name="direction"> направление движения каретки 1 прямое -1 обратное</param>
        public void SetDirection(int direction)
        {
            if(direction == -1 || direction == 1)
            {
                this.direction = direction;
            }
        }
    }
}
