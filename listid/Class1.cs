using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace listid
{
    public class Class1
    {
        // Точка входа программы
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Inimene> list = new List<Inimene>();
            Inimene inimene1 = new Inimene();
            inimene1.Nimi1 = "Prjot 1";
            inimene1.Vanus = 352;
            Inimene inimene2 = new Inimene("Jelizaveta");
            inimene2.Vanus = 63;
            
            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed 

            List<string> ABC = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(@"..\..\..\ABC.txt"))
                {
                    ABC.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fail ei leitud või произошла ошибка при чтении файла.");
            }
            foreach (string e in ABC)
            {
                Console.WriteLine(e);
            }

            // Пример использования ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Enimi");
            Console.WriteLine("Otsing");
            if (vas != null && arrayList.Contains(vas))
            {
                Console.WriteLine("Otsitav element asub" + arrayList.IndexOf(vas));

            }
            // Вывод содержимого ArrayList
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

