namespace Banco01
{
    internal class ContaCorrente : Conta //Herda propriedades da classe PAI (Conta) e adiciona seus próprios atributos
    {
        public ContaCorrente(Cliente cliente) : base(cliente)
        {
        }

        public override void Sacar(double valor) //Sobreescrevendo um método
        {
            base.Sacar(valor+0.2);
        }

    }
}