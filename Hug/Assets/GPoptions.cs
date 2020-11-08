using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPoptions : MonoBehaviour {
    public GameObject one;
    public GameObject two;
    public GameObject tree;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GPO()
    {
        if (one.active == false & two.active == false & tree.active == false)
        {
            one.SetActive(true);
            two.SetActive(true);
            tree.SetActive(true);
        }
        else
        {
            one.SetActive(false);
            two.SetActive(false);
            tree.SetActive(false);
        }
    }
}
