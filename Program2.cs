using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning2_53__lesson_
{
    class Program2  // Udemy course cont
    {
        static void Main(string[] args)
        {
            Character c = new Character();  // экземпляр типа, через точку "." (операция доступа) идет обращение к полям класса Кэректер.
            c.Hit(170, 33); //передаем урон и отравление.   
            Console.WriteLine($"Ouch..Sh#t! You have {c.Health} health remaining after dealing hit");
            
            c.Buff(110, 100 );
            Console.WriteLine($"\n\rWow-wow! You have {c.Health} health after recovery");

            c.Normalize(7);
            Console.WriteLine($"\n\rOkay. You have {c.Health} health after normalization health status");

            Console.WriteLine("\n\rHo-ho, that's my boy! Now you are ready to adventure. But get some sleep first ;))"); // теперь ты красавчик!

            Console.ReadKey();
        }
        
    }
}
