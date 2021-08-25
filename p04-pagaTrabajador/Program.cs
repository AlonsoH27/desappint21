using System;

namespace p04_pagaTrabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, salida;
            int horas;
            float pago, pagoBruto, pagoNeto, impuesto;
            const float tasa = 0.3f;

            Console.WriteLine("Calculando la paga de un trabajor \n");
            Console.WriteLine("Dame tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Horas trabajadas: ");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Pago por hora: ");
            pago = float.Parse(Console.ReadLine());
            
            pagoBruto = horas * pago;
            impuesto = pagoBruto * tasa;
            pagoNeto = pagoBruto - impuesto;

            salida = $"El trabajador {nombre}, trabajo {horas}, con un pago de {pago}\nPago bruto: {pagoBruto}\nImpuesto: {impuesto}\nPago neto: {pagoNeto}";

            Console.WriteLine(salida);

        }
    }
}
