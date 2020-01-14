using System;
using System.Collections.Generic;
using System.Text;

namespace VeiculoCSharp
{
    public class Carro : Veiculo
    {
        public Carro(string marca, string modelo, string cor, float km, int combustivel, bool isLigado, int velocidade, double preco) : base(marca, modelo, cor, km, combustivel, isLigado, velocidade, preco)
        {
        }

     
    }
}
