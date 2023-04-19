namespace Banco01
{
    internal class ContaCorrente : Conta
    {
        public ContaCorrente(Cliente cliente) : base(cliente)
        {
        }

        public override void Sacar(double valor)
        {
            base.Sacar(valor+0.2);
        }

    }
}