using System;

namespace p15_controlbancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco mibanco = new Banco("Banco del norte SA de CV","priva las cumbres 123");
            
            mibanco.AgregarCliente(new Cliente("Carlos", "castalleda"));
            mibanco.AgregarCliente(new Cliente("Juan", "Villa"));
            mibanco.AgregarCliente(new Cliente("Rene", "Ulises"));
            mibanco.AgregarCliente(new Cliente("Sodel", "Vazquez"));

            mibanco.clientes[0].agregarCuenta(new cuentaAhorro(1500,0.10f));
            mibanco.clientes[0].agregarCuenta(new cuentaAhorro(2500,0.20f));
            mibanco.clientes[0].agregarCuenta(new cuentaCheques(6500,500));
            mibanco.clientes[1].agregarCuenta(new cuentaCheques(2500,500));
            mibanco.clientes[2].agregarCuenta(new cuentaCheques(16500,1500));
            mibanco.clientes[2].agregarCuenta(new cuentaAhorro(16500,0.40f));
            mibanco.clientes[3].agregarCuenta(new cuentaAhorro(12500,0.30f));

            mibanco.clientes[1].cuentas[0].retira(3000);
            mibanco.clientes[2].cuentas[0].retira(17000);
            mibanco.clientes[2].cuentas[0].retira(100);

            //Reporte de clientes del banco y el saldo de sus cuentas
            Console.WriteLine($"Reporte del cliente del banco {mibanco.nombre}, {mibanco.direccion}");
            Console.WriteLine($"Clientes {mibanco.clientes.Count}\n");
            foreach (Cliente cte in mibanco.clientes){
                Console.WriteLine($"\n Cliente: {cte.nombre}, {cte.apeido}, cuentas: {cte.cuentas.Count}");
                foreach (CuentaBancaria cta in cte.cuentas)
                {
                    Console.WriteLine((cta is cuentaCheques)?"Cuenta de cheques":"Cuenta de ahorro");
                    if (cta is cuentaCheques)(cta as cuentaAhorro).calcularInteres();
                    {
                        Console.WriteLine($"con un saldo de saldo {cta.saldo}");    
                    }
                }
            }
            Chequitos chk = new Chequitos();
            chk.deposita(100);
            chk.retiraa(0.0f);

        }
    }
}
