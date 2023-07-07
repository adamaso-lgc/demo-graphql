namespace Demo.GraphQL;

public class User
{
    public User(int id, string gamePlatformId, string teamId, string sectorId, string firstName, string surName)
    {
        Id = id;
        GamePlatformId = gamePlatformId;
        TeamId = teamId;
        SectorId = sectorId;
        FirstName = firstName;
        SurName = surName;
    }

    public int Id { get; set; }
    public string GamePlatformId { get; set; }
    public string TeamId { get; set; }
    public string SectorId { get; set; }
    public string FirstName { get; set; }
    public string SurName { get; set; }
}