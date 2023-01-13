using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
    internal interface IGamerService
    {
        void Ekle(Gamer gamer);
        void Sil(Gamer gamer);
        void Guncelle(Gamer gamer);
    }
}
