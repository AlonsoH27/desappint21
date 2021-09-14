namespace p15_controlbancario
{
    public class cuentaCheques : CuentaBancaria {
        
        public cuentaCheques(float saldo, float sobreGiro): base(saldo) {
            this.sobreGiro = sobreGiro;
        }

        public float sobreGiro {get; private set;}

        public virtual bool retira(float cantidad) {
            float requerida = cantidad - saldo;
            if (sobreGiro<requerida)
            {
             return false;   
            }else
            {
                saldo = 0.0f;
                sobreGiro=requerida;
            }
            return true;
        }
    }
}