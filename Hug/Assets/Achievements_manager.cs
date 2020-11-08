using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;

public class Achievements_manager : MonoBehaviour {

    // Use this for initialization
    public void LogIn()
    {
        PlayGamesPlatform.Activate();
        Social.localUser.Authenticate((bool success) =>
        {
            //OnConnectionResponse(success);

        });
    }

    public void ShowLeaderboard()
    {
        Social.ShowLeaderboardUI();
    }
    public void ShowAchievements()
    {
        Social.ShowAchievementsUI();
    }
}
