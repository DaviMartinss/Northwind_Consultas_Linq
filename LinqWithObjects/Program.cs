using System.Linq; 
using static System.Console;
using System;

namespace LinqWithObjects
{
    class Program
    {
                
        static void  LinqWithArrayOfStrings(){ 
            
            var names = new string[] {"Michael" , "Pam" , "Jim" , "Dwight" , "Angela" , "Kevin" , "Toby" , "Creed" };

        //    var query = names.Where(
        //        new Func<string, bool>(NameLongerThanFour));

        //    var query = names.Where(NameLongerThanFour);

        //    var query = names.Where(name => name.Length > 4);

            var query = names
                .Where(name => name.Length > 4)
                .OrderBy(name => name.Length)
                .ThenBy(nome => nome);

            foreach(string item in query){
                WriteLine(item);
            }

        }

        static void LinqWithArrayOfExceptions(){

            var errors = new Exception []
            {
                new ArgumentException(),
                new SystemException(),
                new IndexOutOfRangeException(),
                new InvalidOperationException(),
                new NullReferenceException(),
                new InvalidCastException(),
                new OverflowException(),
                new DivideByZeroException(),
                new ApplicationException()
            };
  
            var numberErros = errors.OfType<ArithmeticException>();
        
            foreach(var erro in numberErros){
                WriteLine(erro);
            }

        }


         static bool NameLongerThanFour(string name)
        {
            
            return name.Length > 4;
        }



        static void Main(string[] args)
        {

            //LinqWithArrayOfStrings();
            LinqWithArrayOfExceptions();
        }

        
    }
}
