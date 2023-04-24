namespace Banco01
{
    internal class ContaPoupanca : Conta //Classe poupança herda propriedade da classe PAI (Conta) e adiciona seus atributos proprios
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
            }
            
        }
    }
}