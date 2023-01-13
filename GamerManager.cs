using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
    internal class GamerManager : IGamerService
    {
        public void Ekle(Gamer gamer)
        {
            if (gamer.TcNo == 15053861874)
            {
                Console.WriteLine("("+gamer.Ad + ") İsimli Oyuncunun Kaydı Eklendi.");
            }
            else
            {
                Console.WriteLine("Oyuncu Ekleme Başarısız *X-X*");
            }
        }

        public void Guncelle(Gamer gamer)
        {
            if (gamer.TcNo == 15053861874)
            {
                Console.WriteLine("(" + gamer.Ad + ") İsimli Oyuncunun Kaydı Güncellendi.");
            }
            else
            {
                Console.WriteLine("Oyuncu Güncelleme Başarısız *X-X*");
            }
        }

        public void Sil(Gamer gamer)
        {
            if (gamer.TcNo == 15053861874)
            {
                Console.WriteLine("(" + gamer.Ad + ") İsimli Oyuncunun Kaydı Silindi.");
            }
            else
            {
                Console.WriteLine("Oyuncu Silme Başarısız *X-X*");
            }
        }
    }
}
