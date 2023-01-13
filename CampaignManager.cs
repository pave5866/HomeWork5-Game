using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
    internal class CampaignManager : ICampaignService
    {
        public void Ekle(Campaign campaign)
        {
            Console.WriteLine("("+campaign.Name + ") Adlı Kampanya Eklendi.");
        }

        public void Guncelle(Campaign campaign)
        {
            Console.WriteLine("(" + campaign.Name + ") Adlı Kampanya Güncellendi.");
        }

        public void Sil(Campaign campaign)
        {
            Console.WriteLine("(" + campaign.Name + ") Adlı Kampanya Silindi.");
        }
    }
}
