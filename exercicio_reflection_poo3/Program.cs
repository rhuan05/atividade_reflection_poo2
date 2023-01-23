using System;
using System.Dynamic;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_reflection_poo3
{
    internal class Program
    {

        static void DisplayPublicProperties(object obj)
        {
            Type t = obj.GetType();
            var propriedades = t.GetProperties();

            foreach (PropertyInfo propriedade in propriedades)
            {
                Console.WriteLine(propriedade.Name);
            }
        }

        static void CreateInstance()
        {
            Type t = typeof(Student);
            object objeto = Activator.CreateInstance(t);
            PropertyInfo nomePropriedade = t.GetProperty("Name");
            nomePropriedade.SetValue(objeto, "Rhuan");
            PropertyInfo universidadeP = t.GetProperty("University");
            universidadeP.SetValue(objeto, "Uninove");
            PropertyInfo rollNumberProp = t.GetProperty("RollNumber");
            rollNumberProp.SetValue(objeto, 123);
            MethodInfo displayMethod = t.GetMethod("DisplayInfo");
            displayMethod.Invoke(objeto, null);
        }

        static void Main(string[] args)
        {

            Student estudante = new Student();
            Console.WriteLine("Propriedades da classe estudante: ");
            DisplayPublicProperties(estudante);

            Console.WriteLine();
            Console.WriteLine("Instância criada: ");
            CreateInstance();

        }

    }
}