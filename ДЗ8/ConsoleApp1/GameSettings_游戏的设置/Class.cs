public class GameSetting
{
    public string PlayerName{ get; set; }
    public int Difficulty{ get; set; }
    public int MusicVolume{ get; set; }

    public GameSetting(string playerName, int difficulty, int musicVolume)
    {
        PlayerName = playerName;
        Difficulty = difficulty;
        MusicVolume = musicVolume;
    }

    public GameSetting()
    {
        PlayerName = "";
        Difficulty = 1;
        MusicVolume = 100;
    }
}