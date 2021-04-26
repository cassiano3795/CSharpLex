using System;
using System.Linq;
using CompiladoresC_.Ex1;
using CompiladoresC_.Ex10;
using CompiladoresC_.Ex2;
using CompiladoresC_.Ex3;
using CompiladoresC_.Ex4;
using CompiladoresC_.Ex5;
using CompiladoresC_.Ex6;
using CompiladoresC_.Ex7;
using CompiladoresC_.Ex8;
using CompiladoresC_.Ex9;

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
            Ex6();
            Ex7();
            Ex8();
            Ex9();
            Ex10();
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

        private static void Ex6()
        {
            Console.WriteLine("Digite uma tag HTML: ");
            var expression = Console.ReadLine();
            var parser = HtmlParser.GetParser();
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

        private static void Ex7()
        {
            Console.WriteLine("Digite uma URL: ");
            var expression = Console.ReadLine();
            var parser = UrlParser.GetParser();
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

        private static void Ex8()
        {
            Console.WriteLine("Digite uma palavra: ");
            var expression = Console.ReadLine();
            var parser = WordParser.GetParser();
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

        private static void Ex9()
        {
            Console.WriteLine("Digite uma string: ");
            var expression = Console.ReadLine();
            var parser = StringParser.GetParser();
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

        private static void Ex10()
        {
            Console.WriteLine("Digite um CNPJ: ");
            var expression = Console.ReadLine();
            var parser = CnpjParser.GetParser();
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
