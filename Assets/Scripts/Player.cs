using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public static float PlayerGold = 1000;
    public static float PlayerScore = 0;
    public static int EnemiesKilled = 0;

    public GameObject GameController;

    // Use this for initialization
    void Start () {
        //GameController.GetComponent<EventManager>().EnemyKilled += eventManager_EnemyKilled;
	}

    private void eventManager_EnemyKilled(float bounty)
    {
        //This doesn't work. Ain't that nice? luckily those values up top are public static for easy access now
        PlayerGold += bounty;
        PlayerScore += bounty;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
