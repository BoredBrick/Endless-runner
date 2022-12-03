using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public class XMLHighScoreManager : MonoBehaviour
{
    public static XMLHighScoreManager instance;
    public Leaderboard leaderboard;
    void Awake()
    {
        instance = this;
        if (!Directory.Exists(Application.persistentDataPath + "/HighScores/"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/HighScores/");
        }
    }
    public void SaveScores(Leaderboard scoresToSave)
    {
        leaderboard = scoresToSave;
        XmlSerializer serializer = new(typeof(Leaderboard));
        FileStream stream = new(Application.persistentDataPath + "/HighScores/highscores.xml", FileMode.Create);
        serializer.Serialize(stream, leaderboard);
        stream.Close();
    }
    public Leaderboard LoadScores()
    {
        if (File.Exists(Application.persistentDataPath + "/HighScores/highscores.xml"))
        {
            XmlSerializer serializer = new(typeof(Leaderboard));
            FileStream stream = new(Application.persistentDataPath + "/HighScores/highscores.xml", FileMode.Open);
            leaderboard = serializer.Deserialize(stream) as Leaderboard;
        }
        return leaderboard;
    }

    [System.Serializable]
    public class Leaderboard
    {
        public List<int> list = new();
    }
}