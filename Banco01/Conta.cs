using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco01
{
    public class Conta //Classe PAI
    {
        //Propriedade da classe CONTA 
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Cliente Cliente { get; set; }

        public Conta(Cliente cliente)
        {

            Cliente=cliente;
            Saldo = 0; 
        }

        //Depositar saldo
        public virtual void Depositar(double valor)
        {
            Saldo += valor;
        }

        //Sacar saldo
        public virtual void Sacar(double valor) { 
            Saldo -= valor;

        }

        //Tranferir saldo
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
