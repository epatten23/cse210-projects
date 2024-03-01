using System;
using System.ComponentModel;
using System.Net.Quic;
using System.Timers;

class Program
{
    static void Main(string[] args)
    {
        Breathing breath = new();
        Reflection reflect = new();
        Listing list = new();
        Console.WriteLine("Hello Develop04 World!");
        while(true){
            Console.Clear();
            Console.Write("Menu Options:\n  1. Start breathing activity \n  2. Start reflecting activity \n  3. Start listing activity \n  4. Quit \nSelect a choice from the menu: ");
            string answer = Console.ReadLine();
            int response = int.Parse(answer);
            if(response == 4){
                break;
            }
            else if(response == 1){
                breath.Play();
            }
            else if(response == 2){
                reflect.Play();
            }
            else if(response == 3){
                list.Play();
            }
            else{
                Console.Write("Invalid input. Please try again");
            }
            }
            }
    }
