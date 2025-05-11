using System;
class Except{
    static void Main(string[] args){
Console.WriteLine("result");

        try{
            int[] a={1,2,3,4,5};
           for(int i=0;i<7;i++){
            Console.WriteLine(a[i++]);
           }
        }
        catch(Exception e){
            Console.WriteLine(e.ToString());
        }}}