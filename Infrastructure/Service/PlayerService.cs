using Domain;
namespace Infrastructure;

public class PlayerService
{
    
public List<Player> _players=new List<Player>();


    public List<Player> GetAll()
    {
        return _players;
    } 

    public void GetById(int id)
    {
       var player = _players.FirstOrDefault(n=>n.Id==id);
       
       System.Console.WriteLine(player.Id);
       System.Console.WriteLine(player.FistName);
       System.Console.WriteLine(player.LastName);
       System.Console.WriteLine(player.Number);
       System.Console.WriteLine(player.Age);
       System.Console.WriteLine(player.Position);
       System.Console.WriteLine(player.Club);
       System.Console.WriteLine(player.TeamClub);
       System.Console.WriteLine(player.Goal);
       System.Console.WriteLine(player.Asist);
       System.Console.WriteLine(player.ChampionsLeagueTrophy);



    }
    public void CreatePlayer(Player player)
    {
        _players.Add(player);
    } 

    public void UpdatePlayer(Player player)
    {        
        var pl = _players.Find(p=>p.Id==p.Id);
        if (pl!=null)
        {
            pl.FistName = player.FistName;
            pl.LastName = player.LastName; 
            pl.Number=player.Number; 
            pl.Age=player.Age; 
            pl.Position=player.Position; 
            pl.Club=player.Club; 
            pl.TeamClub=player.TeamClub; 
            pl.Goal=player.Goal; 
            pl.Asist=player.Asist; 
            pl.ChampionsLeagueTrophy=player.ChampionsLeagueTrophy; 
        }
    } 

    public void DeletePlayer(int id)
    {
        var player = _players.FirstOrDefault(n=>n.Id==id);
        _players.Remove(player);
   
    }

}
