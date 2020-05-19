using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trantandoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exemplo 1
            /*
                        FileStream file = null;
                        //Abre o arquivo dados.txt
                        file = new FileStream(@"C:\aulasCSharp\dado.txt", FileMode.Open);
                        StreamReader sr = new StreamReader(file);
                        string line;

                        //Ler valor do arquivo e exibir no console
                        line = sr.ReadLine();
                        Console.WriteLine(line);
                        file.Close();

              */

            /*
            FileStream file = null;
            try
            {
                //Abre o arquivo dados.txt
                file = new FileStream(@"C:\aulasCSharp\dados1.txt", FileMode.Open);
                StreamReader sr = new StreamReader(file);
                string line;

                 //Ler valor do arquivo e exibir no console
                line = sr.ReadLine();
                Console.WriteLine(line);
                file.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Arquivo não existe {0}", e);
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
           */



            //somar(20,1);


            try
            {
                int divisor = 0;
                Console.WriteLine("{0}", 13 / divisor);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("ToString()     : " + ex.ToString());
                Console.WriteLine("Message        : " + ex.Message);
                Console.WriteLine("Source         : " + ex.Source);
                Console.WriteLine("HelpLink       : " + ex.HelpLink);
                Console.WriteLine("TargetSite     : " + ex.TargetSite);
                Console.WriteLine("Inner Exception: " + ex.InnerException);
                Console.WriteLine("Stack Trace    : " + ex.StackTrace);
                Console.WriteLine("Data           : ");
                if (ex.Data != null)
                {
                    foreach (DictionaryEntry de in ex.Data)
                    {
                        Console.WriteLine("\t{0}: {1}", de.Key, de.Value);
                    }
                }
                Console.ReadKey();
            }



            Console.ReadKey();
        }

        public static void somar(int a, int b)
        {
            try
            {
                if(a > 10)
                {
                   
                    //A exceção que é gerada quando um dos argumentos fornecidos para um método não é válido.
                    throw new ArgumentNullException();
                }

                if(b == 0)
                {
                    throw new ArgumentException();
                }

                if(a ==0)
                {
                    throw new Exception();
                }

                Console.WriteLine("soma= {0} ", a+b);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Argumento nulo.");
                throw new Exception();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro em algum argumento.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro geral");
            }

        }
    }
}
