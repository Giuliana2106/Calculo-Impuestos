using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculo_Impuestos
{
    class Operaciones
    {
        public IVA iv = new IVA();
        public ISR imprent = new ISR();
        public Bono14 bon = new Bono14();
        public Aguinaldo agui = new Aguinaldo();
        public double n = 0;
        public string Resultado(char t)
        {
            double total = 0;

            int j = 0;
            int k = 0;
            int y = 0;
            char op = 'i';
            while (op != 'n')
            {
                if (t == 'i')
                {
                    total = iv.iva(total, Pedir());
                }
                else if (t == 's')
                {

                    if (j == 0)
                    {
                        total = Pedir();
                        j++;
                    }
                    else
                    {

                        total = imprent.isr(total, Pedir());
                    }
                }

                else if (t == 'b')
                {
                    if (k == 0)
                    {
                        total = Pedir();
                        k++;
                    }
                    else
                    {
                        total = bon.bono14(total, Pedir());
                    }
                }
                else if (t == 'a')
                {
                    if (y == 0)
                    {
                        total = Pedir();
                        y++;
                    }
                    else
                    {
                        total = agui.aguinaldo(total, Pedir());
                    }
                }

                Console.Write("Desea ingresar otro valor [s/n] ");
                op = char.Parse(Console.ReadLine());
            }
            return ("El resultado es: " + total);
        }
        private double Pedir()
        {
            double valor = 0;
            bool estado = false;
            while (estado == false)
            {
                Console.Write("Ingrese un valor: ");
                try
                {
                    valor = double.Parse(Console.ReadLine());
                    estado = true;
                }
                catch
                {
                    Console.WriteLine("Ingrese valores numericos...");
                }
            }
            return valor;
        }
    }
}
