using System;
using System.IO;

namespace Gunluk_Odevi
{
	internal class Program
	{
		// günlük uygulaması
		// v1
		// kullanıcımızın her gün bir günlük yazmasını istiyoruz
		// günlük konusu
		// günlük içeriği yazabilir
		// günlük oku, yeni günlük yaz şeklinde menü üzerinden işlem yapacak
		// DateTime kullanımını öğrenmeniz gerekiyor. 
		// Console.WriteLine(DateTime.Now);
		// v2
		// günlüğümüzü txt dosyasına kaydedeceğiz
		// txt'den okuyacağız
		// v3
		// günlük açıldığında şifre istesin
		// günlük kayıtları listelenirken enter'a bastıkça diğer kaydı göstersin

		// tarih
		// bugün öğrencilerime pis bir ödev verdim

		// tarih
		// öğrencilerimin arkamdan sövmemesini temenni ettim


		// HAHAHA
		//Console.Write("Şifreniz: ");
		//string inputPass = Console.ReadLine();
		//Console.WriteLine(inputPass);

		static void Main(string[] args)
		{
			Ad("Miray");
			Menu();
			//oluşturmak istediğim txt yer uzantısı ile beraber
		}
		static void Ad(string ad)
		{
			Console.WriteLine($"{ad} günlüğe hoşgeldin, bizde seni bekliyorduk");
			Console.WriteLine("Menüden seçimini yapmayı unutma\n");
		}
		static void Menu()
		{
			Console.WriteLine("1. Yeni Günlük Yaz");
			Console.WriteLine("2. Günlük Oku");
			Console.WriteLine("Lütfen seçmek istediğin menünün numarasını yaz");
			Console.WriteLine("Örnek günlük yazmak için '1'");
			string menuOku = Console.ReadLine();
			Console.Clear();

			if (menuOku == "1")
			{
				Console.WriteLine("Yeni günlük yazma işlemi seçtiniz.");
				GunlukYaz();
			}
			else if (menuOku == "2")
			{
				Console.WriteLine("Günlük okuma işlemi seçtiniz.");
				Console.Write("Okumak istediğiniz günlüğün başlığını giriniz : \n\n");
				string gunlukAdi = Console.ReadLine();
				string dosyaAdi = $"c:\\odev\\{gunlukAdi}.txt";
				GunlukDosyaOkuma(dosyaAdi);
				string oku = File.ReadAllText(dosyaAdi); //videodan izledim dosyanın içindekini yazdırıyor
                Console.WriteLine(oku);
            }
			else
			{
				Console.WriteLine("Geçersiz seçim yaptınız.");
			}
		}
		static void GunlukYaz()
		{
			Console.Clear();
			Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
			string tarih = DateTime.Now.ToString("dd-MM-yyyy");
			string saat = DateTime.Now.ToString("t");
			Console.WriteLine(tarih + "\n");
			Console.Write("Günlük Konusu : ");
			string konuYaz = Console.ReadLine();
			Console.WriteLine("\nGünlük İçeriği: ");
			string icerikYaz = Console.ReadLine();
			Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
			string metin = $"{tarih}\n{saat}\n{konuYaz}\n{icerikYaz}";
			GunlukDosyaYazdirma($"c:\\odev\\{konuYaz}.txt", metin); //metin belgesinde bütün halde yazsın diye
																	//normalde 2 parametre alıyormuş fazlasını bilmiyorum
			Console.WriteLine("Günlük kaydedildi");
            System.Threading.Thread.Sleep(1000);
			//console ekranında 1 saniye bekletir
		}
		static void GunlukDosyaYazdirma(string path, string deger)
		{
			File.AppendAllText(path, deger);
		}
		static void GunlukDosyaOkuma(string path)
		{
			File.ReadAllText(path);
		}
	}
}
