namespace p15_controlbancario
{
    public class cuentaAhorro : CuentaBancaria {

        public cuentaAhorro(float saldo, float interes) : base(saldo) {
            this.interes = interes;

        }

        public float interes {get; private set;}

        public void calcularInteres() {
            saldo += (saldo*interes);

        }
    }
}