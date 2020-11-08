using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class internet_checker : MonoBehaviour {

    public Text Hugs;
    public GameObject warn;
    

	// Use this for initialization
	void Start () {
        StartCoroutine(Example());
    }
	
	// Update is called once per frame
	void Update () {
        //StartCoroutine(Example());
    }

    void ShowWarn()
    {
        if (Hugs.text == "Loading..." || Hugs.text == "Hugs: 0")
        {
            Debug.Log("No internet! Display warn.");
            warn.SetActive(true);
            StartCoroutine(Example());
        }
        else
        {
            warn.SetActive(false);
            StartCoroutine(Example());
        }
    }

    IEnumerator Example()
    {
        Debug.Log("still loading...");
        yield return new WaitForSeconds(3);
        ShowWarn();
    }
}
