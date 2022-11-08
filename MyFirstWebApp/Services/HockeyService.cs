namespace MyFirstWebApp.Services
{
    public class HockeyService
    {
        public List<HockeyPlayers> GetAllPlayers()
        {
            return new List<HockeyPlayers>
            {
                new HockeyPlayers{Id = 1, Name = "Cico", Team = "FC Barcelona"},
                new HockeyPlayers{Id = 2, Name = "Bolo", Team = "FC Amsterdam"},
                new HockeyPlayers{Id = 3, Name = "Hrvoje", Team = "FC Dinamo Zagreb"}
            };
        }

       
    }
}
