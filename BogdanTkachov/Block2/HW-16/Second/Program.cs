using System;
using System.Text;

namespace Second
{
    // 2. Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для поиска по книге.
    // При вызове этого метода, производится последовательный поиск строки в книге. (Книга любая, подгружаем с помощью Filestream)

    static class FindAndReplaceManager
    {
        public static void FindNext(string str, string foundWord)
        {
            string[] array = str.Split(' ');
            foreach (var item in array)
            {
                if (item == foundWord)
                {
                    Console.WriteLine("We found your word");
                    goto end;
                }
            }
            Console.WriteLine("We can not found(");
        end:;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            string str = "C# — объектно-ориентированный язык программирования. Разработан в 1998—2001 годах группой инженеров компании Microsoft под руководством Андерса Хейлсберга и Скотта Вильтаумота как язык разработки приложений для платформы Microsoft .NET Framework. Впоследствии был стандартизирован как ECMA-334 и ISO/IEC 23270";
            FindAndReplaceManager.FindNext(str, "годах");
        }
    }
}
