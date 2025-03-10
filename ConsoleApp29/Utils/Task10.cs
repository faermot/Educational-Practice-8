using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Utils
{
    public class Task10
    {
        private int theme;
        private char variant;

        public Task10(int theme, char variant)
        {
            this.theme = theme;
            this.variant = variant;
        }

        public void Calculate()
        {
            string[] themes = { "Новогодние", "С Днем Рождения", "С Днем Защитника Отечества" };
            if (theme >= 1 && theme <= 3 && (variant == 'a' || variant == 'b' || variant == 'c'))
                Console.WriteLine($"{themes[theme - 1]}, вариант {variant}");
            else
                Console.WriteLine("Неправильный номер темы или варианта.");
        }
    }
}
