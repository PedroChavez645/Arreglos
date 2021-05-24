using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        //Declaraciones de tipo vector
        //Unidimensional o de dimension simple
        //int[] valores;
        //valores = new int[100];

        //Arreglos multidimensionales
        //int[,,] valores1 = new int[3, 7, 9];

        //Arreglos de arreglos

        //int[][] matriz = new int[3][];
        //  for (int i = 0; i<matriz.Length; i++)
        //  {
        // matriz[i] = new int[4];




        //Realizar un programa que guarde los sueldos de 5 trabajadores en un arreglo de tipo vector
        //Declaracion de vector
        private int[] sueldos;

        public void CargarSalarios()
        {
            
            //Iniciar vector en 5
            sueldos = new int[6];
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingrese el sueldo del trabajador " + i + ": ");
                string lineacaptura = Console.ReadLine();
                sueldos[i] = int.Parse(lineacaptura); //Asignamos sueldos al vector
            }

        }

        public void imprimir()
        {
            Console.WriteLine("Los 5 sueldos de los trabajadores son");
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("[" + sueldos[i] + "]");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program sueldos = new Program();
            sueldos.CargarSalarios();
            sueldos.imprimir();



        }
    
    }

     
}
