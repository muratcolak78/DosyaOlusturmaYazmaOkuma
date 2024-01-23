using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaOlusturmaYazmaOkuma
{
    internal class Dosya
    {

        private string dosyaYolu = "C:\\Users\\murat\\dosyaOlusturYazOku\\";
        private string dosyaAdi;
        public Dosya(string dosyaAdi) { 
            this.dosyaAdi = dosyaAdi;
        this.dosyaYolu += dosyaAdi;
            DosyaOlustur();
        }


        public void DosyaOlustur()
        {
            if (!File.Exists(dosyaYolu))
            {
                Console.WriteLine(dosyaAdi+" başarılı bir şekilde oluşturuldu");
                File.Create(dosyaYolu).Close();
            }
        }



        public void DosyayaYaz(string metin)
        {
            
            // Dosyayı yazma modunda aç
            using (StreamWriter sw = new StreamWriter(dosyaYolu, true))
            {
                // Metni dosyaya yaz
                sw.WriteLine(metin);
            }

            Console.WriteLine("Başarıyla yazıldı.");
        }

        public string DosyadanOku()
        {
            // Dosya var mı kontrol et
            if (!File.Exists(dosyaYolu))
            {
                Console.WriteLine("Dosya bulunamadı.");
                return null;
            }

            // Dosyayı okuma modunda aç
            using (StreamReader sr = new StreamReader(dosyaYolu))
            {
                // Dosyadan metni oku
                string okunanMetin = sr.ReadToEnd();
                return okunanMetin;
            }
        }
    }
}
