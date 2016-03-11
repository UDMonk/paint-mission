using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour {


    public Text goldText;
    public Text killsText;
    
    public float killsCount;
    //public float goldCount;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //goldCount += 5 * Time.deltaTime;

        //goldText.text = "Gold : " + Math.Round (goldCount);
	}
}
