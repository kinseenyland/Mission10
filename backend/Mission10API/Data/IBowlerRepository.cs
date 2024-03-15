namespace Mission10API.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }

        IEnumerable<Team> Teams { get; }

        IEnumerable<Bowler> GetAllBowlersWithTeams();
    }
}
