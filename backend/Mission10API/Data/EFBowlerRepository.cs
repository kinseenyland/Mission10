namespace Mission10API.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerContext _bowlerContext;

        public EFBowlerRepository(BowlerContext temp)
        {
            _bowlerContext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;
        public IEnumerable<Team> Teams => _bowlerContext.Teams;

        public IEnumerable<Bowler> GetAllBowlersWithTeams()
        {
            var joinedData = from bowler in _bowlerContext.Bowlers
                             join team in _bowlerContext.Teams
                             on bowler.TeamID equals team.TeamID
                             select new
                             {
                                 BowlerID = bowler.BowlerID,
                                 BowlerFirstName = bowler.BowlerFirstName,
                                 BowlerLastName = bowler.BowlerLastName,
                                 TeamName = team.TeamName,
                                 BowlerAddress = bowler.BowlerAddress,
                                 BowlerCity = bowler.BowlerCity,
                                 BowlerState = bowler.BowlerState,
                                 BowlerZip = bowler.BowlerZip,
                                 BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                             };
            var bowlerWithTeam = joinedData
                .Select(b => new Bowler 
                {
                    BowlerID = b.BowlerID,
                    BowlerFirstName = b.BowlerFirstName,
                    BowlerLastName = b.BowlerLastName,
                    BowlerAddress = b.BowlerAddress,
                    BowlerCity = b.BowlerCity,
                    BowlerState = b.BowlerState,
                    BowlerZip = b.BowlerZip,
                    BowlerPhoneNumber = b.BowlerPhoneNumber,
                    TeamName =  b.TeamName
                })
                .ToList();


            return bowlerWithTeam;
        }
    }
}   
