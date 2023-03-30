using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_5_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string ShowColor()
            {
                var color = Console.ReadLine();
                switch (color)
                {
                    case "color":
                        break;
                }
                return color;
            }
            Console.WriteLine("Введите 3 цвета");
            var favcolors = new string[3];
            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor();
            }

            Console.WriteLine("Ваши лбимые цвета:");
            foreach (var item in favcolors)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
