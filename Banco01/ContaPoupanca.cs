namespace Banco01
{
    internal class ContaPoupanca : Conta
    {
        public ContaPoupanca(Cliente cliente) : base(cliente)
        {
        }

        public override void Sacar(double valor)
        {
            if (valor <= 1000)
            {
                base.Sacar(valor + 0.1);
            }
            else
            {
                MessageBox.Show("Esse valor não pode ser sacado!");
                //mensagem dizendo que não pode sacar >1000
            }
            
        }
    }
}