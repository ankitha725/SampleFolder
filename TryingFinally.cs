using System;
class MultipleExceptions{
    static void Main(){
        try{
            Console.WriteLine("Enter a number: ");
            int n=int.Parse(Console.ReadLine());
            int c=10/n;
            Console.WriteLine(c);
        }
        catch(Exception e){
            if(e is FormatException||e is DivideByZeroException){//Foramt Exception is For identifying Type!!!
                Console.WriteLine(e.Message);
            }
            else{
                Console.WriteLine(e.Message);
            }
            
        }   
    }
}