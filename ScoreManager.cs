using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class ScoreManager {
    
    public static Players Players;

    public static string tempo;

    static float time;

    public static void SetSilentimes(string user, string score)
    {
        time = float.Parse(score);

        if (Players.Silentimes.ContainsKey(user) == false)
        {   //non-existing user
            Players.Silentimes.Add(user, time);
        }
        else
        {
            Players.Silentimes[user] += time;
        }
    }

    public static float GetSilentimes(string user)
    {

        if (Players.Silentimes.ContainsKey(user) == false)
        {
            return 0;
        }

        return Players.Silentimes[user];

    }

    public static string[] Getusers()
    {
        string[] users = Players.Silentimes.Keys.ToArray();

        return users.OrderByDescending(u => GetSilentimes(u)).ToArray();
    }

}

[Serializable]
public class Players
{
    public Dictionary<string, float> Silentimes;
}


