using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;

public class GIven_Hugs : MonoBehaviour {

    public int givenHugs = 0;
    public Text givenHugsText;

    public GameObject IT;
    public InputField IF;
	// Use this for initialization
	void Start () {
        givenHugs = PlayerPrefs.GetInt("hugs");
        StartCoroutine(Example());
    }
	
	// Update is called once per frame
	void Update () {
        givenHugsText.text = "Given hugs:" + givenHugs;

        if(givenHugs == 12)
        {
            IT.SetActive(true);
            if(IF.text == "zaq12")
            {
                UnlockAchievement(GPGS.achievement_secret_hugger);
                Debug.Log(">>>>>>>>>>secret achievement");
            }
        }
        else
        {
            IT.SetActive(false);
        }

        if (givenHugs >= 1000)
        {
            UnlockAchievement(GPGS.achievement_1000_hugs_given);
        }
        if (givenHugs >= 100)
        {
            UnlockAchievement(GPGS.achievement_100_hugs_given);
        }
        if (givenHugs >= 10000)
        {
            UnlockAchievement(GPGS.achievement_10k_hugs_given);
        }
        if (givenHugs >= 10)
        {
            UnlockAchievement(GPGS.achievement_10_hugs_given);
        }
        if (givenHugs >= 11000)
        {
            UnlockAchievement(GPGS.achievement_11k_hugs_given);
        }
        if (givenHugs >= 12000)
        {
            UnlockAchievement(GPGS.achievement_12k_hugs_given);
        }
        if (givenHugs >= 13000)
        {
            UnlockAchievement(GPGS.achievement_13k_hugs_given);
        }
        if (givenHugs >= 1500)
        {
            UnlockAchievement(GPGS.achievement_1500_hugs_given);
        }
        if (givenHugs >= 150)
        {
            UnlockAchievement(GPGS.achievement_150_hugs_given);
        }
        if (givenHugs >= 15000)
        {
            UnlockAchievement(GPGS.achievement_15k_hugs_given);
        }
        if (givenHugs >= 2000)
        {
            UnlockAchievement(GPGS.achievement_2000_hugs_given);
        }
        if (givenHugs >= 200)
        {
            UnlockAchievement(GPGS.achievement_200_hugs_given);
        }
        if (givenHugs >= 20000)
        {
            UnlockAchievement(GPGS.achievement_20k_hugs_given);
        }
        if (givenHugs >= 2500)
        {
            UnlockAchievement(GPGS.achievement_2500_hugs_given);
        }
        if (givenHugs >= 250)
        {
            UnlockAchievement(GPGS.achievement_250_hugs_given);
        }
        if (givenHugs >= 25000)
        {
            UnlockAchievement(GPGS.achievement_25k_hugs_given);
        }
        if (givenHugs >= 25)
        {
            UnlockAchievement(GPGS.achievement_25_hugs_given);
        }
        if (givenHugs >= 3000)
        {
            UnlockAchievement(GPGS.achievement_3000_hugs_given);
        }
        if (givenHugs >= 30000)
        {
            UnlockAchievement(GPGS.achievement_30k_hugs_given);
        }
        if (givenHugs >= 3500)
        {
            UnlockAchievement(GPGS.achievement_3500_hugs_given);
        }
        if (givenHugs >= 35000)
        {
            UnlockAchievement(GPGS.achievement_35k_hugs_given);
        }
        if (givenHugs >= 4000)
        {
            UnlockAchievement(GPGS.achievement_4000_hugs_given);
        }
        if (givenHugs >= 40000)
        {
            UnlockAchievement(GPGS.achievement_40k_hugs_given);
        }
        if (givenHugs >= 4500)
        {
            UnlockAchievement(GPGS.achievement_4500_hugs_given);
        }
        if (givenHugs >= 45000)
        {
            UnlockAchievement(GPGS.achievement_45k_hugs_given);
        }
        if (givenHugs >= 5000)
        {
            UnlockAchievement(GPGS.achievement_5000_hugs_given);
        }
        if (givenHugs >= 500)
        {
            UnlockAchievement(GPGS.achievement_500_hugs_given);
        }
        if (givenHugs >= 50000)
        {
            UnlockAchievement(GPGS.achievement_50k_hugs_given);
        }
        if (givenHugs >= 50)
        {
            UnlockAchievement(GPGS.achievement_50_hugs_given);
        }
        if (givenHugs >= 5)
        {
            UnlockAchievement(GPGS.achievement_5_hug_given);
        }
        if (givenHugs >= 6000)
        {
            UnlockAchievement(GPGS.achievement_6000_hugs_given);
        }
        if (givenHugs >= 60000)
        {
            UnlockAchievement(GPGS.achievement_60k_hugs_given);
        }
        if (givenHugs >= 7000)
        {
            UnlockAchievement(GPGS.achievement_7000_hugs_given);
        }
        if (givenHugs >= 70000)
        {
            UnlockAchievement(GPGS.achievement_70k_hugs_given);
        }
        if (givenHugs >= 750)
        {
            UnlockAchievement(GPGS.achievement_750_hugs_given);
        }
        if (givenHugs >= 8000)
        {
            UnlockAchievement(GPGS.achievement_8000_hugs_given);
        }
        if (givenHugs >= 80000)
        {
            UnlockAchievement(GPGS.achievement_80k_hugs_given);
        }
        if (givenHugs >= 9000)
        {
            UnlockAchievement(GPGS.achievement_9000_hugs_given);
        }
        if (givenHugs >= 90000)
        {
            UnlockAchievement(GPGS.achievement_90k_hugs_given);
        }
        if (givenHugs >= 100000)
        {
            UnlockAchievement(GPGS.achievement_ultimate_hugger_3);
        }

    }

    public void GIveHug()
    {
        givenHugs++;
        PlayerPrefs.SetInt("hugs", givenHugs);
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
    private void Awake()
    {
        PlayGamesPlatform.Activate();
        Social.localUser.Authenticate((bool success) =>
        {
            OnConnectionResponse(success);

        });
    }

    IEnumerator Example()
    {

        yield return new WaitForSeconds(5);
        AddScore();
        
    }

    public void AddScore()
    {
        Social.ReportScore(givenHugs, "CgkI0NzDuMwQEAIQNg", (bool success) => {
            // handle success or failure
        });
        StartCoroutine(Example());
    }
}
