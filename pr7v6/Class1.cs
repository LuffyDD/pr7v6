using System;

namespace pr7v6
{
    public class Class1
    {

        public string modelCPU;
        public string country;
        public int kernel;
        public string VidCard;
        public string typeMemor;
        public int potokiv;
        public void CPUinfo()
        {


            Console.WriteLine(" Модель процесора : {0}\n країна виробник : {1}\n кількість ядер : {2}\n інтегрована відеопамять : {3}\n тип памяті : {4}\n кількість потоків : {5}", modelCPU, country, kernel, VidCard, typeMemor, potokiv);
        }
    }
}
