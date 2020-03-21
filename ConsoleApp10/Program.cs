/*****************************************************
**             SAKARYA ÜNİVERSİTESİ
**     BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**         BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**        NESNEYE DAYALI PROGRAMLAMA DERSİ
**             2018-2019 BAHAR DÖNEMİ
**
**             ÖDEV NUMARASI......:2    
**             ÖĞRENCİ ADI........:AHMET SELİM ÖZTÜRK   
**             ÖĞRENCİ NUMARASI...:G181210082
**             DERSİNİ ALDIĞI GRUP:2B
****************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            Random RastgeleSayi = new Random();

            List<Futbolcu> takim = new List<Futbolcu>();

            takim.Add(new Futbolcu("Fernando Muslera", 0));//kaleci
            takim.Add(new Defans("Giorgio Chiellini", 1));
            takim.Add(new Defans("Mats Hummels", 2));
            takim.Add(new Defans("Marcelo", 3));
            takim.Add(new Defans("Dani Alves", 4));
            takim.Add(new OrtaSaha("Paul Pogba", 5));
            takim.Add(new OrtaSaha("Luka Modric", 6));
            takim.Add(new OrtaSaha("Paulo Dybala", 7));
            takim.Add(new OrtaSaha("David Silva", 8));
            takim.Add(new Forvet("Cristiano Ronaldo", 9));
            takim.Add(new Forvet("Zlatan Ibrahimovic", 10));

            int FormaNo;
            int gecici = 0;
            Boolean gololabilir = true;
            //3 oyuncunun birbirine pas atabilmesi için for döngüsü
            for (int i = 1; i <= 3; i++)
            {
                FormaNo = RastgeleSayi.Next(1, 11);
                //Rastegele oluşturulan forma numarası önceki forma numarasına eşitse döngüden çıkar.Futbolcu kendine pas veremez.Gol olmaz.
                if (gecici == FormaNo)
                {
                    Console.WriteLine("FUTBOLCU KENDİNE PAS ATAMAZ");
                    gololabilir = false;
                    break;
                }
                //Rastgele çağırılan oyuncunun PasVer metodundan gelcek değer 60'dan küçükse pas başarısız.Topu rakibe kaptırdık :)
                if (takim[FormaNo].PasVer() < 60)
                {
                    gololabilir = false;
                    Console.WriteLine("PAS BAŞARISIZ");
                    break;
                }

                Console.WriteLine(takim[FormaNo].AdSoyad + " " + FormaNo + "  PASI BAŞARILI ");

                gecici = FormaNo;
            }

            if (gololabilir)
            {
                FormaNo = RastgeleSayi.Next(1, 11);
                //Rastegele oluşturulan forma numarası önceki forma numarasına eşitse futbolcu kendine pas atamaz.
                if (gecici == FormaNo)
                {
                    Console.WriteLine("FUTBOLCU KENDİNE PAS ATAMAZ GOL VURUSU YAPILAMADI");
                }
                //Rastgele çağırılan oyuncunun GolVurusu metodundan gelcek değer 70'den büyükse ve önceki forma numarası rastgele oluşan forma numarasına
                // eşit değilse gol olur.
                else if ((takim[FormaNo].GolVurusu()) > 70 && (gecici != FormaNo))
                {
                    Console.Write("GOLLL   " + FormaNo + " " + takim[FormaNo].AdSoyad);
                }
                //Rastgele çağırılan oyuncunun GolVurusu metodundan gelcek değer 70'den küçükse gol vuruşu başarısız.
                else if (takim[FormaNo].GolVurusu() < 70)
                {
                    Console.WriteLine(takim[FormaNo].AdSoyad+" GOL VURUŞU YAPAMADI");
                }

                Console.Read();
            }
        }
    }
}
