using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;

public class add : MonoBehaviour {

    Highscores highscoresManager;
    public Text scoreUI;
    public string UItext= "";
    public int preview = 0;
    public Text viewedScore;

    public GameObject Adding;

    private void Awake()
    {
        PlayGamesPlatform.Activate();
        Social.localUser.Authenticate((bool success) =>
        {
            OnConnectionResponse(success);

        });
    }

    public void LogIn()
    {
        PlayGamesPlatform.Activate();
        Social.localUser.Authenticate((bool success) =>
        {
            OnConnectionResponse(success);

        });
    }

    public void UnlockAchievement(string achievementID)
    {
        Social.ReportProgress(achievementID, 100.0f, (bool success) =>
        {
            Debug.Log("Osiagniecie odblokowane" + success.ToString());
        });


    }
    private void OnConnectionResponse(bool authenticated)
    {
        if (authenticated)
        {

        }
        else
        {

        }
    }


    private void Start()
    {
        highscoresManager = GetComponent<Highscores>();
    }

    // Update is called once per frame
    void Update () {
        UItext = "" + scoreUI.text;
        int score = 0;
        int.TryParse(UItext, out score);
        preview = score;

        viewedScore.text = "Hugs: " + score;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Highscores.AddNewHighscore("zaq12", 1);
            //Highscores.AddNewHighscore("zaq12", score);
            //highscoresManager.DownloadHighscores();
            //Debug.Log("new score" + score);
        }

        if (preview >= 5000)
        {
            UnlockAchievement(GPGS.achievement_got_5k_hugs);
        }
        if (preview >= 750000)
        {
            UnlockAchievement(GPGS.achievement_got_750k_hugs);
        }
        if (preview >= 50000)
        {
            UnlockAchievement(GPGS.achievement_got_50k_hugs);
        }
        if (preview >= 500)
        {
            UnlockAchievement(GPGS.achievement_got_500_hugs);
        }
        if (preview >= 500000)
        {
            UnlockAchievement(GPGS.achievement_got_500k_hugs);
        }
        if (preview >= 2000)
        {
            UnlockAchievement(GPGS.achievement_got_2k_hugs);
        }
        if (preview >= 25000)
        {
            UnlockAchievement(GPGS.achievement_got_25k_hugs);
        }
        if (preview >= 250000)
        {
            UnlockAchievement(GPGS.achievement_got_250k_hugs);
        }
        if (preview >= 1000)
        {
            UnlockAchievement(GPGS.achievement_got_1k_hugs);
        }
        if (preview >= 150000)
        {
            UnlockAchievement(GPGS.achievement_got_150k_hugs);
        }
        if (preview >= 10000)
        {
            UnlockAchievement(GPGS.achievement_got_10k_hugs);
        }
        if (preview >= 100000)
        {
            UnlockAchievement(GPGS.achievement_got_100k_hugs);
        }
        if (preview >= 1000000)
        {
            UnlockAchievement(GPGS.achievement_most_hugged_person);
        }





    }

    public void AddHug()
    {
        Highscores.AddNewHighscore("zaq12", preview + 1);
        StartCoroutine(Example());
        Adding.SetActive(true);
    }

    IEnumerator Example()
    {
        
        yield return new WaitForSeconds(5);

        Adding.SetActive(false);
    }
}
