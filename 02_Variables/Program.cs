using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doubleDegiskenler
            /*
            Console.WriteLine("***** Fiyat Listesi *****");
            Console.WriteLine();
            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string turkishLira = "₺";
            Console.WriteLine("---Elma Birim Fiyat:" + applePrice + turkishLira);
            Console.WriteLine("---Portakal Birim Fiyat:" + orangePrice + turkishLira);
            Console.WriteLine("---Cilek Birim Fiyat:" + strawberryPrice + turkishLira);
            Console.WriteLine("---Patates Birim Fiyat:" + potatoPrice + turkishLira);
            Console.WriteLine("---Domates Birim Fiyat:" + tomatoPrice + turkishLira);

            double appleGram, orangeGram, straberryGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            straberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;
            Console.WriteLine();
            Console.WriteLine("***** Ödenecek Tutar *****");
            Console.WriteLine();
            double appleTotalPrice = applePrice * appleGram;
            double orangeTotalPrice = orangePrice * orangeGram;
            double straberryTotalPrice = strawberryPrice * straberryGram;
            double potatoTotalPrice = potatoPrice * potatoGram;
            double tomatoTotalPrice = tomatoPrice * tomatoGram;
            Console.WriteLine("Alınan Ürün: Elma- " + "Birim Fiyat: " + applePrice + " -Gramaj: " + appleGram + " -Toplam Tuatar: " + appleTotalPrice + turkishLira);
            Console.WriteLine("Alınan Ürün: Portakal- " + "Birim Fiyat: " + orangePrice + " -Gramaj: " + orangeGram + " -Toplam Tuatar: " + orangeTotalPrice + turkishLira);
            Console.WriteLine("Alınan Ürün: Çilek- " + "Birim Fiyat: " + strawberryPrice + " -Gramaj: " + straberryGram + " -Toplam Tuatar: " + straberryTotalPrice + turkishLira);
            Console.WriteLine("Alınan Ürün: Patates- " + "Birim Fiyat: " + potatoPrice + " -Gramaj: " + potatoGram + " -Toplam Tuatar: " + potatoTotalPrice + turkishLira);
            Console.WriteLine("Alınan Ürün: Domates- " + "Birim Fiyat: " + tomatoPrice + " -Gramaj: " + tomatoGram + " -Toplam Tuatar: " + tomatoTotalPrice + turkishLira);
            
            double shoppingTotalPrice=appleTotalPrice+orangeTotalPrice+straberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;
            Console.WriteLine();
            Console.WriteLine("Ödenecek Toplam miktar:" + shoppingTotalPrice + turkishLira);
            */
            #endregion

            #region charDegiskenler
            /*
            char symbol = 'M';
            Console.WriteLine(symbol);
            */
            #endregion

            #region klavyedenVeriGirisleriStringDegiskenler
            /*
            Console.WriteLine("***CSharp Hava Yolları Yolcu Bilgisi***");
            Console.WriteLine();
            string passengerName, passengerSurName, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            Console.Write("Yolcu Adı:");
            passengerName =Console.ReadLine();

            Console.Write("Yolcu SoyAdı:");
            passengerSurName = Console.ReadLine();

            Console.Write("İlçe Bilgisi:");
            passengerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi:");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaşı:");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu TC Bilgisi:");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine("Yolcu TC Kimlik No:" + passengerIdentityNumber  +  " " + "-"+ "Yolcu Ad Soyad:" +  passengerName +
                " " + passengerSurName + passengerDistrict+ "/" + passengerCity);
            */

            #endregion

            #region klavyedenTamSayiGirisleriveDönüsümleri
            /*
            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 2000;
            computerPrice = 45000;
            chairPrice = 30000;
            tvPrice = 17000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("lütfen aldığınız ayakkabı sayısını giriniz:");
            shoesCount=int.Parse(Console.ReadLine());

            Console.Write("lütfen aldığınız bilgisayar sayısını giriniz:");
            computerCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("lütfen aldığınız sandalye sayısını giriniz:");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("lütfen aldığınız TV sayısını giriniz:");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            Console.WriteLine();
            Console.WriteLine("Toplam ödememiz gereken tutar:" + totalPrice);
            */
            #endregion

            #region klavyedenOndalıklıSayiIslemleri
            /*
            double exam1, exam2, exam3, result;
            Console.Write("1.sınav notunu giriniz:");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("2.sınav notunu giriniz:");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("3.sınav notunu giriniz:");
            exam3 = double.Parse(Console.ReadLine());
            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine();
            Console.WriteLine("sınav ortalamanız:" + result);
            */

            #endregion

            #region klavyedenKarakterGirisleri

            char gender;
            Console.Write("ltfn cinsiyet seçiniz:");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiğiniz cinsiyet:" + gender);
            #endregion
            Console.ReadLine();

        }
    }
}
