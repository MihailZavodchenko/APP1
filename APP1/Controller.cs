using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace APP1
{/// <summary>
/// Конторллер приложения Желательно всю логику и функции описывать тут а не на форме
/// </summary>
    class Controller
    {

        public void ReadFIle(string FileName)
        {
            data data = new data();
            StreamReader SR = new StreamReader(FileName, Encoding.Default);

            string[] buf = SR.ReadLine().Split(';');

            if(buf[0] == "Файл:")
            {
                if(buf[1].Contains("Forward") == true)
                {
                    data.SetDirection(0);
                }
            }

            SR.ReadLine();
            SR.ReadLine();
            SR.ReadLine();
            SR.ReadLine();
            
            while(!SR.EndOfStream)
            {
                buf = SR.ReadLine().Split(';');
                data.measurements.Add(new measurement(int.Parse(buf[0]), double.Parse(buf[1])));
            }
        }
    }
}
