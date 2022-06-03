using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    Console.WriteLine($"Интовый {result}");
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Введите целое число");
                }
            }
            int i = 5;
            try
            {
                //var a = 5;
                //var b = a / 0;
                //throw new DivideByZeroException("test");
                throw new MyOwnException();
            }
            catch(MyOwnException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex) when (i == 5)
            {
                Console.WriteLine("i = 5");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Деление на ноль");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Какое-то исключение....");
                throw;
            }
            finally
            {
                Console.WriteLine("Работа завершена");
                Console.ReadLine();
            }
            //Console.WriteLine(a);
            //Console.WriteLine(b);
        }
    }
}
