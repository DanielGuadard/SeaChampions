using System.IO;
using UnityEngine;

public static class JSONHandler
{

    public static void SaveTeamsToJSON(CardListJSONFile[] teams, string filename)
    {
        string content = JsonHelper.ToJson<CardListJSONFile>(teams);
        WriteFile(GetPath(filename), content);
    }

    public static CardListJSONFile[] ReadTeamsFromJSON(string filename)
    {
        string content = ReadFile(GetPath(filename));

        if (string.IsNullOrEmpty(content) || content == "{}")
        {
            return new CardListJSONFile[3];
        }
        CardListJSONFile[] result = JsonHelper.FromJson<CardListJSONFile>(content);

        return result;
    }

    public static void SaveConfigToJSON(ConfigJSON config, string filename)
    {
        string content = JsonUtility.ToJson(config);
        WriteFile(GetPath(filename), content);
    }

    public static ConfigJSON ReadConfigFromJSON(string filename)
    {
        string content = ReadFile(GetPath(filename));

        if (string.IsNullOrEmpty(content) || content == "{}")
        {
            return new ConfigJSON(80, 80, 0, 0, false);
        }
        ConfigJSON result = JsonUtility.FromJson<ConfigJSON>(content);

        return result;
    }

    private static string GetPath(string filename)
    {
        return Application.persistentDataPath + "/" + filename;
    }

    private static void WriteFile(string path, string content)
    {
        FileStream fileStream = new FileStream(path, FileMode.Create);

        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(content);
        }
    }

    private static string ReadFile(string path)
    {
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string content = reader.ReadToEnd();
                return content;
            }
        }
        return "";
    }

}

[System.Serializable]
public class CardListJSONFile
{
    public string name;
    public CardJSONFile[] deck;

    public CardListJSONFile(string name, CardJSONFile[] deck)
    {
        this.name = name;
        this.deck = deck;
    }
}

[System.Serializable]
public class CardJSONFile
{
    public int cardID;

    public CardJSONFile(int cardID)
    {
        this.cardID = cardID;
    }
}

[System.Serializable]
public class ConfigJSON
{
    public int musicVolume;
    public int soundVolume;
    public int resolution;
    public int gamemode;
    public bool isFullScreen;

    public ConfigJSON(int musicVolume, int soundVolume, int resolution, int gamemode, bool isFullScreen)
    {
        this.musicVolume = musicVolume;
        this.soundVolume = soundVolume;
        this.resolution = resolution;
        this.isFullScreen = isFullScreen;
        this.gamemode = gamemode;
    }
}

public static class JsonHelper
{
    public static T[] FromJson<T>(string json)
    {
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
        return wrapper.Teams;
    }

    public static string ToJson<T>(T[] array)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Teams = array;
        return JsonUtility.ToJson(wrapper);
    }

    public static string ToJson<T>(T[] array, bool prettyPrint)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Teams = array;
        return JsonUtility.ToJson(wrapper, prettyPrint);
    }

    [System.Serializable]
    private class Wrapper<T>
    {
        public T[] Teams;
    }
}
