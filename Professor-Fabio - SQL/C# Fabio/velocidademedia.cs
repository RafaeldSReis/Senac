using System;

namespace velocidade_média
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Velocidade Média */

            int kmpercorrida, kmapercorrer;
            double tempogasto, tempoagastar, vel_media;

            Console.WriteLine("Calculando Tempo de Percurso e Velocidade Média");
            Console.WriteLine("Informe Km Percorrido (KMs)");
            kmpercorrida = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe tempo gasto na km percorrida (Hs)");
            tempogasto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe Km a Percorrer");
            kmapercorrer = Convert.ToInt32(Console.ReadLine());

            vel_media = kmpercorrida / tempogasto;
            tempoagastar = (kmapercorrer * tempogasto) / kmpercorrida;

            Console.WriteLine("Velocidade Média " + vel_media);
            Console.WriteLine("Tempo a gastar para percorrer os Km solicitados " + tempoagastar.ToString("f2"));

            Console.ReadLine();
        }
    }
}
