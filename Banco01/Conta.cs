using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco01
{
    public class Conta
    {
        public int Numero { get; set; }
        private double Saldo { get; set; }
        public Cliente Cliente { get; set; }

        public Conta(Cliente cliente)
        {

            Cliente=cliente;
            Saldo = 0; 
        }

        public virtual void Depositar(double valor)
        {
            Saldo += valor;
        }

        public virtual void Sacar(double valor) { 
            Saldo -= valor; //Saldo = Saldo - valor

        }

        public virtual void Transferir(double valor)
        {
            Saldo -= valor;
        }

        public string getSaldo()
        {
            return Saldo.ToString();
        }

    }
}
