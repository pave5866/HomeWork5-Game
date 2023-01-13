namespace Odev5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.TcNo = 15053861874;
            gamer.Id = 1;
            gamer.Ad = "Kadir";
            gamer.SoyAd = "Erdem";
            gamer.DogumYili = new DateTime(2000, 11, 23);

            GamerManager gamerManager = new GamerManager();
            gamerManager.Ekle(gamer);
            gamerManager.Guncelle(gamer);
            gamerManager.Sil(gamer);

            Console.WriteLine("-----------------------------------------");

            GameSale gameSale = new GameSale();
            gameSale.Id = 1;
            gameSale.GameName = "Valorant";
            gameSale.GameType = "FPS Oyunu";

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.Name = "Yeni Yıl Kampanyası";
            campaign.Time = "10 Saat";
            campaign.Description = "Her Yıl Gerçekleşen Kampanya Modülüdür.";

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Ekle(campaign);
            campaignManager.Guncelle(campaign);
            campaignManager.Sil(campaign);
            
            Console.WriteLine("-----------------------------------------");

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.SatisIadeEt(gameSale, gamer, campaign);
            gameSaleManager.SatisIptalEt(gameSale, gamer,campaign);
            gameSaleManager.SatisYap(gameSale, gamer, campaign);

            Console.ReadKey();
        }
    }
}