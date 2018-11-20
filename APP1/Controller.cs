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
        data[] data;//массив данных 

        /// <summary>
        /// Считывание файлов
        /// </summary>
        /// <param name="FileName">Массив имен файлов</param>
        public void ReadFIle(string[] FileName)
        {
            data = new data[FileName.Length];

            for (int i = 0; i < FileName.Length; i++)
            {
                data[i] = new data();

                StreamReader SR = new StreamReader(FileName[i], Encoding.Default);

                string[] buf = SR.ReadLine().Split(';');

                if (buf[0] == "Файл:")
                {
                    if (buf[1].Contains("Forward") == true)
                    {
                        data[i].SetDirection(0);
                    }
                    if (buf[1].Contains("Reverse") == true)
                    {
                        data[i].SetDirection(-1);
                    }
                }
                else
                    throw new Exception("Данные в файле(файлах) в неправильном формате");

                // Пропуск Строк
                SR.ReadLine(); //Start
                SR.ReadLine(); //Stop
                SR.ReadLine(); //Параметры
                SR.ReadLine(); //Шаг Амплитуда 

                while (!SR.EndOfStream)//Считываем значения измерений
                {
                    buf = SR.ReadLine().Split(';');
                    data[i].measurements.Add(new measurement(int.Parse(buf[0]), double.Parse(buf[1])));
                }
            }
        }
    }
}
