using System;

namespace VeiculoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Carro A1 = new Carro(null, null, null,0,100,false,0,0 );



            A1.ligar();
            A1.acelerar(20);
            A1.acelerar(20);
            A1.acelerar(20);
            A1.acelerar(20);
            A1.acelerar(20);
            A1.abastecer(10);
            A1.freiar(20);
            A1.freiar(20);
            A1.freiar(20);
            A1.freiar(20);
            A1.freiar(20);
            A1.freiar(20);
            A1.desligar();

            Caminhao B1 = new Caminhao(null, null, null, 0, 100, false, 0, 0);

            B1.ligar();
            B1.acelerar(20);
            B1.acelerar(20);
            B1.acelerar(20);
            B1.acelerar(20);
            B1.acelerar(20);
            B1.abastecer(10);
            B1.freiar(20);
            B1.freiar(20);
            B1.freiar(20);
            B1.freiar(20);
            B1.freiar(20);
            B1.freiar(20);
            B1.desligar();


            Aviao C1 = new Aviao(null, null, null, 0, 100, false, 0, 0);

            C1.ligar();
            C1.acelerar(20);
            C1.acelerar(20);
            C1.acelerar(20);
            C1.acelerar(20);
            C1.acelerar(20);
            C1.abastecer("10");
            C1.freiar(20);
            C1.freiar(20);
            C1.freiar(20);
            C1.freiar(20);
            C1.freiar(20);
            C1.freiar(20);
            C1.desligar();

        }
    }
}
