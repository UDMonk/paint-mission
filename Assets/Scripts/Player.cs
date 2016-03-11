using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public float PlayerGold;
    public float PlayerScore;
    public GameObject GameController;

    // Use this for initialization
    void Start () {
        PlayerGold = 1000;
        PlayerScore = 0;
        GameController.GetComponent<EventManager>().EnemyKilled += eventManager_EnemyKilled;
	}

    private void eventManager_EnemyKilled(float bounty)
    {
        PlayerGold += bounty;
        PlayerScore += bounty;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
