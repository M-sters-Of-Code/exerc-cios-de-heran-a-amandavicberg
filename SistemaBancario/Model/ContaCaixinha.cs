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

        public ContaCaixinha(decimal saldoInicial) : base(saldoInicial)
        {
        }

        public override void Depositar(decimal valor)
        {
            if (valor < 1.00m)
                throw new ArgumentOutOfRangeException("Depósitos inferiores a R$1,00 não são permitidos.");

            base.Depositar(valor + 1.00m); // Bônus de R$1,00
        }

        public override void Sacar(decimal valor)
        {
            base.Sacar(valor + 5.00m); // Penalidade de R$5,00
        }
    }
}