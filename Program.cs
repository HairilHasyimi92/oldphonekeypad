using System;
using System.Collections;
using System.Linq;

namespace OldPhonePad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("Welcome to The Old Phone Messaging App");
            Console.WriteLine("*****************************************\n\n");
            Console.WriteLine("*Please input one type of number each time and press Enter");
            Console.WriteLine("*Send '*' to erase one character" );
            Console.WriteLine("Send '#' to show the word\n\n");

            Console.WriteLine("Type the first character: ");
            string numMessage = Console.ReadLine();
            ArrayList msgList = new ArrayList();

            while(numMessage.Contains('#')!= true){
                
                if(numMessage.Contains("1")){
                    if(numMessage.Length == 1){
                        msgList.Add(".");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else if(numMessage.Length == 2){
                        msgList.Add("?");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else {
                        msgList.Add(",");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }

                }else if(numMessage.Contains("2")){
                    if(numMessage.Length == 1){
                        msgList.Add("a");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else if(numMessage.Length == 2){
                        msgList.Add("b");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else{
                        msgList.Add("c");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }

                }else if(numMessage.Contains("3")){
                    if(numMessage.Length == 1){
                        msgList.Add("d");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else if(numMessage.Length == 2){
                        msgList.Add("e");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else{
                        msgList.Add("f");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }

                }else if(numMessage.Contains("4")){
                    if(numMessage.Length == 1){
                        msgList.Add("g");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else if(numMessage.Length == 2){
                        msgList.Add("h");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else{
                        msgList.Add("i");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }

                }else if(numMessage.Contains("5")){
                    if(numMessage.Length == 1){
                        msgList.Add("j");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else if(numMessage.Length == 2){
                        msgList.Add("k");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else{
                        msgList.Add("l");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }

                }else if(numMessage.Contains("6")){
                    if(numMessage.Length == 1){
                        msgList.Add("m");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else if(numMessage.Length == 2){
                        msgList.Add("n");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else{
                        msgList.Add("o");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }

                }else if(numMessage.Contains("7")){
                    if(numMessage.Length == 1){
                        msgList.Add("p");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else if(numMessage.Length == 2){
                        msgList.Add("q");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else if(numMessage.Length == 3){
                        msgList.Add("r");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else{
                        msgList.Add("s");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }

                }else if(numMessage.Contains("8")){
                    if(numMessage.Length == 1){
                        msgList.Add("t");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else if(numMessage.Length == 2){
                        msgList.Add("u");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else{
                        msgList.Add("v");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }

                }else if(numMessage.Contains("9")){
                    if(numMessage.Length == 1){
                        msgList.Add("w");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else if(numMessage.Length == 2){
                        msgList.Add("x");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else if(numMessage.Length == 3){
                        msgList.Add("y");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }else{
                        msgList.Add("z");
                        Console.WriteLine("Type next character: ");
                        numMessage = Console.ReadLine();
                    }

                }else if(numMessage.Contains("*")){
                    msgList.RemoveAt((msgList.Count)-1);
                    Console.WriteLine("Type next character: ");
                    numMessage = Console.ReadLine();

                }else if(numMessage.Contains("0")){
                    msgList.Add(" ");
                    Console.WriteLine("Type next character: ");
                    numMessage = Console.ReadLine();

                }else{
                    Console.WriteLine("Please enter a valid number!");
                    Console.WriteLine("Type next character: ");
                    numMessage = Console.ReadLine();
                }
            }
            var fmsg = string.Join("", msgList.ToArray());
            Console.WriteLine(fmsg);
            


        }
    }
    
        
    

    
}