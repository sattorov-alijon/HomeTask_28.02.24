using System.Collections;
using Domain;
using Infrastructure;


var player=new Player();
var playerService=new PlayerService();


for (;;)
{
    System.Console.WriteLine("Farmonro baroi ijroish intikhob kuned: GetAll  CreatPlayer  UpdatePlayer  DeletePlayer  GetByID");
string a=Console.ReadLine();
 if(a=="GetAll")
    {
        foreach (var item in playerService.GetAll())
        {
             System.Console.Write("Id: ");
            System.Console.WriteLine(item.Id);
        System.Console.Write("FirstName: ");
            System.Console.WriteLine(item.FistName);
        System.Console.Write("LastName: ");
            System.Console.WriteLine(item.LastName);
        System.Console.Write("Number: ");
            System.Console.WriteLine(item.Number);
        System.Console.Write("Age: ");
            System.Console.WriteLine(item.Age);
      
        System.Console.Write("Position: ");
            System.Console.WriteLine(item.Position);
                System.Console.Write("Club: ");
            System.Console.WriteLine(item.Club);
                System.Console.Write("TeamClub: ");
            System.Console.WriteLine(item.TeamClub);
        System.Console.Write("Goal: ");
            System.Console.WriteLine(item.Goal);
        System.Console.Write("Asist: ");
            System.Console.WriteLine(item.Asist);
        System.Console.Write("ChampionsLeagueTrophy: ");
            System.Console.WriteLine(item.ChampionsLeagueTrophy);

        }
    }
    else if(a=="GetById")
    {
        System.Console.WriteLine("Kiro didan mekhohed, id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        playerService.GetById(id);
    }
    else if(a=="CreatPlayer")
    {
        var players = new Player();
        System.Console.Write("Id: ");
        players.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("FirstName: ");
        players.FistName = Console.ReadLine();
        System.Console.Write("LastName: ");
        players.LastName = Console.ReadLine();
        System.Console.Write("Number: ");
        players.Number = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Age: ");
        players.Age = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Position: ");
        players.Position = Console.ReadLine();
                System.Console.Write("Club: ");
        players.Club = Console.ReadLine();
                System.Console.Write("TeamClub: ");
        players.TeamClub = Console.ReadLine();
        System.Console.Write("Goal: ");
        players.Goal = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Asist: ");
        players.Asist = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("ChampionsLeagueTrophy: ");
        players.ChampionsLeagueTrophy = Convert.ToInt32(Console.ReadLine());
        
        

        playerService.CreatePlayer(players);
        System.Console.WriteLine("Bozingar ba  listi bozingaron dokhil shud!");
        System.Console.WriteLine("***************************************");
    }
    else if(a=="UpdatePlayer")
    {
         var players = new Player();
        System.Console.Write("Kadom bozingarro taghiyr dodan mekhohed, id: ");
        players.Id = Convert.ToInt32(Console.ReadLine());
       players.Id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("FirstName: ");
        players.FistName = Console.ReadLine();
        System.Console.Write("LastName: ");
        players.LastName = Console.ReadLine();
        System.Console.Write("Number: ");
        players.Number = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Age: ");
        players.Age = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Position: ");
        players.Position = Console.ReadLine();
                System.Console.Write("Club: ");
        players.Club = Console.ReadLine();
                System.Console.Write("TeamClub: ");
        players.TeamClub = Console.ReadLine();
        System.Console.Write("Goal: ");
        players.Goal = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Asist: ");
        players.Asist = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("ChampionsLeagueTrophy: ");
        players.ChampionsLeagueTrophy = Convert.ToInt32(Console.ReadLine());
     
        playerService.UpdatePlayer(players);
        System.Console.WriteLine("Malumothoi bozingar ivaz karda shud!");
        System.Console.WriteLine("***************************************");
    }
    else if(a=="DeletePlayer")
    {
        System.Console.WriteLine("Kadom bozingarro udalit kardan mekhohed, id: ");
        int del = Convert.ToInt32(Console.ReadLine());
        playerService.DeletePlayer(del);
        System.Console.WriteLine("Bozingar udalit karda shud");
        System.Console.WriteLine("***************************************");
    }
}
   

