namespace SistemaBancario.Model
{
    public class ContaCaixinha : Conta
    {
        public ContaCaixinha(Cliente cliente) : base(cliente, 10.00m)
        {
        }

        public ContaCaixinha(Cliente cliente, decimal saldoInicial) : base(cliente, saldoInicial)
        {
        }

        public override void Depositar(decimal valor)
        {
            if (valor < 1.00m)
                throw new ArgumentException("Depósitos inferiores a R$1,00 não são permitidos.");

            base.Depositar(valor + 1.00m); // Bônus de R$1,00
        }

        public override void Sacar(decimal valor)
        {
            base.Sacar(valor + 5.00m); // Penalidade de R$5,00
        }
    }
}