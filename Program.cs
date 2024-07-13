// See https://aka.ms/new-console-template for more information

using GameDemo.Abstract;
using GameDemo.Concerete;
using GameDemo.Entities;

Game game = new Game();
game.Id = 1;
game.GameName = "Sims4";
game.GamePrice =700;

Campaign campaign = new Campaign();
campaign.Id = 1;
campaign.CampaignName = "BIG SALE";
campaign.DiscountAmount = 25;


Gamer gamer1 = new Gamer();
gamer1.Id = 1;
gamer1.GamerName = "Hande";
gamer1.GamerLastName = "Mencik";
gamer1.TCKimlikNo = "235678";
gamer1.BirthYear = new DateTime(2000, 07, 02);

Gamer gamer2 = new Gamer();
gamer2.Id = 2;
gamer2.GamerName = "Fatih";
gamer2.GamerLastName = "Aydın";
gamer2.TCKimlikNo = "294707";
gamer2.BirthYear = new DateTime(2000, 11, 11);

Gamer[] gamers = new Gamer[2];

GamerManager gamerManager = new GamerManager(new UserCheckManager());
gamerManager.Register(gamer1);
gamerManager.Register(gamer2);

SaleManager saleManager = new SaleManager();
saleManager.Sale(gamer1, game,campaign);

CampaignManager campaignManager = new CampaignManager();
campaignManager.Add(campaign);

 