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
        int direction; // направление движение каретки 0 прямое -1 обратное
        public List<measurement> measurements;

        public data()
        {
            measurements = new List<measurement>();
        }

        public void SetDirection(int direction)
        {
            if(direction == -1 || direction == 0)
            {
                this.direction = direction;
            }
        }
    }
}
