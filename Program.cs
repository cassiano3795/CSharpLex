using System;
using System.Linq;
using CompiladoresC_.Ex1;
using CompiladoresC_.Ex2;
using CompiladoresC_.Ex3;
using CompiladoresC_.Ex4;
using CompiladoresC_.Ex5;
using sly.parser;

namespace CompiladoresC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            Ex2();
            Ex3();
            Ex4();
            Ex5();
        }

        private static void Ex1()
        {
            Console.WriteLine("Digite um número de telefone: ");
            var expression = Console.ReadLine();
            var parser = PhoneNumberParser.GetParser();
            var r = parser.Parse(expression);

            if (!r.IsError && r.Result != null)
            {
                Console.WriteLine($"Resultado de <{expression}>: {r.Result}");
            }
            else
            {
                if (r.Errors != null && r.Errors.Any())
                {
                    // display errors
                    r.Errors.ForEach(error => Console.WriteLine(error.ErrorMessage));
                }
            }
        }

        private static void Ex2()
        {
            Console.WriteLine("Digite uma placa: ");
            var expression = Console.ReadLine();
            var parser = PlateParser.GetParser();
            var r = parser.Parse(expression);

            if (!r.IsError && r.Result != null)
            {
                Console.WriteLine($"Resultado de <{expression}>: {r.Result}");
            }
            else
            {
                if (r.Errors != null && r.Errors.Any())
                {
                    // display errors
                    r.Errors.ForEach(error => Console.WriteLine(error.ErrorMessage));
                }
            }
        }

        private static void Ex3()
        {
            Console.WriteLine("Digite um CPF: ");
            var expression = Console.ReadLine();
            var parser = CpfParser.GetParser();
            var r = parser.Parse(expression);

            if (!r.IsError && r.Result != null)
            {
                Console.WriteLine($"Resultado de <{expression}>: {r.Result}");
            }
            else
            {
                if (r.Errors != null && r.Errors.Any())
                {
                    // display errors
                    r.Errors.ForEach(error => Console.WriteLine(error.ErrorMessage));
                }
            }
        }

        private static void Ex4()
        {
            Console.WriteLine("Digite uma matricula: ");
            var expression = Console.ReadLine();
            var parser = RegistrationParser.GetParser();
            var r = parser.Parse(expression);

            if (!r.IsError && r.Result != null)
            {
                Console.WriteLine($"Resultado de <{expression}>: {r.Result}");
            }
            else
            {
                if (r.Errors != null && r.Errors.Any())
                {
                    // display errors
                    r.Errors.ForEach(error => Console.WriteLine(error.ErrorMessage));
                }
            }
        }

         private static void Ex5()
        {
            Console.WriteLine("Digite um número real: ");
            var expression = Console.ReadLine();
            var parser = RealParser.GetParser();
            var r = parser.Parse(expression);

            if (!r.IsError && r.Result != null)
            {
                Console.WriteLine($"Resultado de <{expression}>: {r.Result}");
            }
            else
            {
                if (r.Errors != null && r.Errors.Any())
                {
                    // display errors
                    r.Errors.ForEach(error => Console.WriteLine(error.ErrorMessage));
                }
            }
        }
    }
}
