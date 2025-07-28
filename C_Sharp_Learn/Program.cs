namespace C_Sharp_Learn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //__Yazı Yazma (İki string değer beraber yazma)__

            Console.Write("Yezı yaz : ");
            string text = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Hello, World!\nYazın : " + text);


            //--------------------------------------------------------


            //__Şiir Yazma (Array kullanımı, for dögüsü kullanımı)__

            //string[] arrays;

            //Console.Write("Şiir kaç satır olucak : ");
            //int prop = int.Parse(Console.ReadLine());

            //arrays = new string[prop];

            //Console.Clear();

            //for (int i = 0; i < prop; i++)
            //{
            //    Console.WriteLine((i + 1) + ". Satırı yaz ;");
            //    arrays[i] = Console.ReadLine();

            //    Console.Clear();
            //}

            //Console.Clear();
            //Console.WriteLine("Yazdıklarınız ;");

            //for (int i = 0; i < prop; i++)
            //{
            //    Console.WriteLine(arrays[i]);
            //}


            //--------------------------------------------------------


            //__To Do List (List kullanımı, if-else şartı, metod içinde metod kullanımı, for döngüsü, while döngüsü)__

            //List<string> list = new List<string>();
            //string type = "";

            //void processList()
            //{
            //    Console.WriteLine("[y] to do list ekleme yap\n" +
            //        "[o] to do list oku\n" +
            //        "[e] çıkış yap\n\n" +
            //        "İşlem no girin ;");
            //}

            //while (true)
            //{
            //    processList();
            //    type = Console.ReadLine();
            //    Console.Clear();

            //    if (type == "y")
            //    {
            //        Console.WriteLine("To do list ekleme yapın ;");
            //        list.Add(Console.ReadLine());
            //        Console.WriteLine("To do list eklendi");
            //    }
            //    else if (type == "o")
            //    {
            //        Console.WriteLine("To do list de bulunanlar ;");
            //        for (int i = 0; i < list.Count; i++)
            //        {
            //            Console.WriteLine((i + 1) + " - " +list[i].ToUpper());
            //        }
            //    }
            //    else if (type == "e") 
            //    {
            //        Console.WriteLine("Programdan çıkılıyor...");
            //        return;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı işlem yaptınız!");
            //    }

            //    Console.WriteLine("(Geçmek için bir tuşa basın)");
            //    Console.ReadKey();
            //    Console.Clear();
            //}


            //--------------------------------------------------------


            //__Hesap Makinası (Değer Döndüren Metodlar, Değer Döndürmeyen Metodlar, Switch Case şartı, Static kavramı, Obje kavramı, While döngüsü)__

            //Program program = new Program();

            //int x = 0;
            //int y = 0;
            //int sonuc = 0;
            //char type = '_';

            //while (true)
            //{
            //    Console.Write("1. Sayını Gir : ");
            //    x = double.Parse(Console.ReadLine());

            //    Console.Write("2. Sayını Gir : ");
            //    y = double.Parse(Console.ReadLine());

            //    Console.Write("[+] TOPLAMA\n" +
            //        "[-] FARK\n" +
            //        "[*] ÇARPMA\n" +
            //        "[/] BÖLME\n" +
            //        "[E] ÇIKMAK İÇİN\n\n" +
            //        "İşlem türü seçin : ");
            //    type = char.Parse(Console.ReadLine());

            //    Console.Clear();

            //    switch (type)
            //    {
            //        case '+':
            //            sonuc = program.toplama(x, y); //1.
            //            program.yazdir(sonuc); //1.

            //            //sonuc = program.toplama(x, y); //2.
            //            //program.yazdir("Toplama işleminin sonucu : ", sonuc); //2.

            //            //program.yazdir(program.toplama(x, y)); //3.

            //            //yazdir(x + " + " + y + " = ", toplama(x, y)); //4.
            //            break;
            //        case '-':
            //            sonuc = program.cikarma(x, y); //1.
            //            program.yazdir(sonuc); //1.

            //            //sonuc = program.cikarma(x, y); //2.
            //            //program.yazdir("Fark işleminin sonucu : ", sonuc); //2.

            //            //program.yazdir(program.cikarma(x, y)); //3.

            //            //yazdir(x + " - " + y + " = ", cikarma(x, y)); //4.
            //            break;
            //        case '*':
            //            sonuc = program.carpma(x, y); //1.
            //            program.yazdir(sonuc); //1.

            //            //sonuc = program.carpma(x, y); //2.
            //            /program.yazdir("Çarpma işleminin sonucu : ", sonuc); //2.

            //            //program.yazdir(program.carpma(x, y)); //3.

            //            //yazdir(x + " * " + y + " = ", carpma(x, y)); //4.
            //            break;
            //        case '/':
            //            sonuc = program.bolme(x, y); //1.
            //            program.yazdir(sonuc); //1.

            //            //sonuc = program.bolme(x, y); //2.
            //            //program.yazdir("Bölme işleminin sonucu : ", sonuc); //2.

            //            //program.yazdir(program.bolme(x, y)); //3.

            //            //yazdir(x + " / " + y + " = ", bolme(x, y)); //4.
            //            break;
            //        case 'E':
            //            Console.Clear();

            //            program.yazdir("Programdan çıkılıyor...");

            //            //yazdir("Programdan çıkılıyor...");
            //            return;
            //        default:
            //            program.yazdir("[+] TOPLAMA\n" +
            //        "[+] TOPLAMA\n" +
            //        "[-] FARK\n" +
            //        "[*] ÇARPMA\n" +
            //        "[/] BÖLME\n" +
            //        "[E] ÇIKMAK İÇİN\n\n" +
            //        "Bu işlem türlerinde birini seçin");

            //            /*
            //            yazdir("[+] TOPLAMA\n" +
            //        "[+] TOPLAMA\n" +
            //        "[-] FARK\n" +
            //        "[*] ÇARPMA\n" +
            //        "[/] BÖLME\n" +
            //        "[E] ÇIKMAK İÇİN\n\n" +
            //        "Bu işlem türlerinde birini seçin");
            //            */

            //            Console.ReadKey();
            //            Console.Clear();
            //            break;
            //    }
            //}
        }


        //HESAP MAKİNESİ (4. aşamada static de yorum satırlarını kaldır)
        //private /*static*/ double toplama(double x, double y)
        //{
        //    return x + y;
        //}

        //private /*static*/ double cikarma(double x, double y)
        //{
        //    return x - y;
        //}

        //private /*static*/ double carpma(double x, double y)
        //{
        //    return x * y;
        //}

        //private /*static*/ double bolme(double x, double y)
        //{
        //    return x / y;
        //}

        //private /*static*/ void yazdir(double sonuc)
        //{
        //    Console.WriteLine("İşlem Sonucunuz : " + sonuc);
        //}

        //private /*static*/ void yazdir(string yazi)
        //{
        //    Console.WriteLine(yazi);
        //}

        //private /*static*/ void yazdir(string yazi, double sonuc)
        //{
        //    Console.WriteLine(yazi + sonuc);
        //}
    }
}
