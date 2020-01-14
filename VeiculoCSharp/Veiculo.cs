using System;
using System.Collections.Generic;
using System.Text;

namespace VeiculoCSharp
{
    public abstract class Veiculo
    {
        protected string _marca;
        protected string _modelo;
        protected string _cor;
        protected float _km;
        protected int _combustivel;
        protected Boolean _isLigado;
        protected int _velocidade;
        protected double preco;

        protected Veiculo(string marca, string modelo, string cor, float km, int combustivel, bool isLigado, int velocidade, double preco)
        {
            _marca = marca;
            _modelo = modelo;
            _cor = cor;
            _km = km;
            _combustivel = combustivel;
            _isLigado = isLigado;
            _velocidade = velocidade;
            this.preco = preco;
        }

        public void ligar()
        {
            _isLigado = true;
            Console.WriteLine("O carro está ligado");
        }

        public void acelerar(int quantidade)
        {
            if (_isLigado)
            {
                int velocidadeNova = this._velocidade + quantidade;
                this._velocidade = velocidadeNova;
                _combustivel = _combustivel - 1;
                Console.WriteLine("O carro está " + _velocidade + "Km/h");
            }
            else
            {
                Console.WriteLine("O carro está desligado");
            }
        }


        public void abastecer(int quantidade)
        {
            Console.WriteLine("Seu tanque é: " + _combustivel);
            if (_combustivel <= 100)
            {
                if (quantidade <= (100 - _combustivel))
                {
                    _combustivel = _combustivel + quantidade;
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


        public void freiar(int quantidade)
        {
            if (_isLigado && _velocidade != 0)
            {
                int velocidadeNova = this._velocidade - quantidade;
                this._velocidade = velocidadeNova;

                Console.WriteLine("O carro está " + _velocidade + "Km/h");
            }
            else
            {
                Console.WriteLine("O carro já está parado");
            }
        }


        public void pintar(String novacor)
        {
            Console.WriteLine("A cor atual é: " + _cor);
            _cor = novacor;
            Console.WriteLine("Você pintou o carro de: " + novacor);
        }
        public void desligar()
        {
            if (_velocidade == 0)
            {
                _isLigado = false;
                Console.WriteLine("O carro está desligado");
            }
            else
            {
                Console.WriteLine("O carro está em movimento");
            }
        }
    }
}
