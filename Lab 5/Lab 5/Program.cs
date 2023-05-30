/* вариант 12 
 * (Виды учебных занятий)
В качестве пунктов меню предложить: «*.JPG», «*.GIF», «*.PNG», «*.BMP», «*.SVG», 
«Выход». Реализовать «пролистывание» меню без контроля границ диапазона. Возврат 
курсора в границы диапазона меню реализовать по клавише «Пробел». Подтверждение 
выбранного пункта меню реализовать по клавише «Enter». Выбор пункта вне диапазона 
реализует возврат курсора в диапазон.*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string[] menuItems = new string[] { "*.JPG", "*.GIF", "*.PNG", "*.BMP", "*.SVG", "Выход" };
        int selectedItemIndex = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Выберите вид учебных занятий:");
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == selectedItemIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                Console.WriteLine(menuItems[i]);
                Console.ResetColor();
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedItemIndex--;
                    if (selectedItemIndex < 0)
                    {
                        selectedItemIndex = menuItems.Length - 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    selectedItemIndex++;
                    if (selectedItemIndex >= menuItems.Length)
                    {
                        selectedItemIndex = 0;
                    }
                    break;
                case ConsoleKey.Spacebar:
                    selectedItemIndex = 0;
                    break;
                case ConsoleKey.Enter:
                    if (selectedItemIndex == menuItems.Length - 1)
                    {
                        return;
                    }
                    Console.WriteLine($"\nВы выбрали {menuItems[selectedItemIndex]}");
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
    }
}