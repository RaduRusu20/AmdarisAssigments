#define MYCOND
using _05.ExceptionHandlingAndDebugging;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
#if MYCOND // doar daca am #define MYCOND e valabil codul
        public static void Password(string password)
        {
            if (password == null)
            {
                throw new NullReferenceException("Parola nu trebuie sa fie nula!!!");
            }

            if (password.Length < 10)
            {
                throw new InvalidPasswordException("Parola trebuie sa aibe cel putin 10 caractere!!!");
            }
        }
#endif

#if DEBUG //daca debug-ul e activ doar atunci functioneaza acest cod
        public static void Log(Exception e)
        {
            Console.WriteLine(e.Message);
        }
#endif

        static void Main(string[] args)
        {

            /*
            Stream file = null;

             using  var file3 = File.Open("", FileMode.Create);

            //echivalent cu

            using (var file2 = File.Open("", FileMode.Create))
            {

            }

            try
            {
                file = File.Open("my file name", FileMode.Append);
                //do something
            }
            finally
            {
                if (file != null)
                    file.Dispose();
            }
            */

            try
            {
                DoSomething();
            }
            catch (InvalidPasswordException e)
            {
                Log(e);
            }
            catch(NullReferenceException e)
            {
                Log(e);
                Log(e.InnerException);            }
           
        }

        public static void DoSomething()
        {
            string s = null;
            try
            {
                Password(s);
            }
            catch (InvalidPasswordException e)
            {
                Log(e);
                throw;
            }
            catch (NullReferenceException e)
            {
                Log(e);
                throw new NullReferenceException("Provine din DoSomething", e);
            }
            finally
            {
                Console.WriteLine("Gata");
            }
            Console.WriteLine("Gata1");
        }

    }
}