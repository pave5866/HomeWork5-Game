using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
    internal class GameSaleManager : IGameSaleService
    {

        public void SatisIadeEt(GameSale gameSale, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("*" + gameSale.GameName + "* Adlı Oyun (" + gamer.Ad + ")" + " İsimli Oyuncu Tarafından İade Edildi.");
        }

        public void SatisIptalEt(GameSale gameSale, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("*" + gameSale.GameName + "* Adlı Oyun (" + gamer.Ad + ")" + " İsimli Oyuncu Tarafından İptal Edildi.");
        }

        public void SatisYap(GameSale gameSale, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("*"+ gameSale.GameName + "* Adlı Oyun (" +  gamer.Ad + ")"+ " İsimli Oyuncu Tarafından "+ "(" +campaign.Name + ") Adlı Kampanyayı Kullanarak" + " Satın Alındı.");
        }

    }
}
