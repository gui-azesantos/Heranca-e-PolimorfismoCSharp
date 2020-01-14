using System;
using System.Collections.Generic;
using System.Text;

namespace VeiculoCSharp
{
    class Aviao : Veiculo
    {
        public Aviao(string marca, string modelo, string cor, float km, int combustivel, bool isLigado, int velocidade, double preco) : base(marca, modelo, cor, km, combustivel, isLigado, velocidade, preco)
        {
        }
        public  void abastecer(String quantidade)
        {
            Console.WriteLine("Seu tanque é: " + _combustivel);
            if (_combustivel <= 100)
            {
                int iquantidade = Convert.ToInt32(quantidade);


                if (iquantidade <= (100 - _combustivel))
                {
                    _combustivel = _combustivel + iquantidade;
                    Console.WriteLine("Seu tanque é A: " + _combustivel);
                }
                else
                {
                    Console.WriteLine("A quantidade de combustivel é maior do que a capacidade do tanque");
                    Console.WriteLine("Seu tanque é B: " + _combustivel);
                }
            }
            else
            {
                Console.WriteLine("Tanque cheio!");
            }
        }
    }
}
