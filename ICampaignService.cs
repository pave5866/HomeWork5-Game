using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
    internal interface ICampaignService
    {
        void Ekle(Campaign campaign);
        void Sil(Campaign campaign);
        void Guncelle(Campaign campaign);
    }
}
