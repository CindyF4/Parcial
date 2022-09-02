using System;
using System.Collections;

namespace Parcial
{
    class Program
    {

        static void Main(string[] args)
        {
            int Roses;
            do
            {
                int numberStudents;
                ArrayList registro = new ArrayList();
                string nombre;
                int edad;
                double nota1;
                double nota2;
                double parcial;
                double promedio;
      
                int contador = 0;

                Console.WriteLine("Ingrese el numero de estudiantes a evaluar: ");
                numberStudents = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                while (contador < numberStudents)
                {
                    Console.Write("Ingrese el nombre del estudiante: ");
                    nombre = Console.ReadLine();
                    Console.Write("Ingrese la edad del estudiante: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota de Laboratorio 1: ");
                    nota1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota de Laboratorio 2: ");
                    nota2 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota parcial: ");
                    parcial = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    promedio = (nota1 * .3) + (nota2 * .3) + (parcial * .4);

                    Console.WriteLine("El promedio total del alumno es: {0}", promedio);

                     if (promedio >= 6)
                     {
                        Console.WriteLine("ALUMNO APROBADO");
                        
                     }
                    else 
                    {
                       Console.WriteLine("ALUMNO REPROBADO");
                    }
                    
                    


                    Students students = new Students() { Nombre = nombre, Edad = edad, Nota1 = nota1, Nota2 = nota2, Parcial = parcial, Promedio = promedio };
                    registro.Add(students);

                    contador++;
                }
                

                Console.WriteLine(" --- RESULTADOS --- ");
                foreach (Students st in registro)
                {
                    Console.WriteLine(st.getData());
                }

                Console.WriteLine("¿Quiere finalizar el proceso? Escriba el numero 5");
                Roses = Convert.ToInt32(Console.ReadLine());

            } while (Roses != 5);
            Console.WriteLine("Finalizo el proceso");
        }



    }




    public class Students
    {

        private string _nombre;
        private int _edad;
        private double _nota1;
        private double _nota2;
        private double _parcial;
        private double _promedio;

        public string Nombre
        {

            get => _nombre;
            set => _nombre = value;

        }

        public int Edad
        {
            get => _edad;
            set => _edad = value;
        }

        public double Nota1
        {
            get => _nota1;
            set => _nota1 = value;
        }

        public double Nota2
        {
            get => _nota2;
            set => _nota2 = value;
        }

        public double Parcial
        {
            get => _parcial;
            set => _parcial = value;
        }

        public double Promedio
        {
            get => _promedio;
            set => _promedio = value;
        }
        
        public string getData()
        {
            return "Nombre: " + _nombre + " Edad: " + _edad + " Nota1:" + _nota1 + " Nota2: " + _nota2 + " Parcial: " + Parcial + " Promedio: " + Promedio  ;
        }
        
    }
    
}
