using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
    internal interface IGameSaleService
    {
        void SatisYap(GameSale gameSale, Gamer gamer , Campaign campaign);
        void SatisIptalEt(GameSale gameSale, Gamer gamer, Campaign campaign);
        void SatisIadeEt(GameSale gameSale, Gamer gamer, Campaign campaign);
    }
}
