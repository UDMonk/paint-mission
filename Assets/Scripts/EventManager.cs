using UnityEngine;
using System.Collections;
using System;

public class EventManager : MonoBehaviour
{
    public GameObject baseEnemy; //listen for events triggered in enemy classes
    public Enemy enemyScript;
    public event EnemyKilledEventHandler EnemyKilled;
    public event TowerCollideEventHandler EnemyReachedGoal;


    // Use this for initialization
    void Start ()
    {
        enemyScript.EnemyHasKill += EnemyHasKill;
        
        enemyScript.EnemyHasReachedGoal += EnemyHasReachedGoal;
    }

    private void EnemyHasReachedGoal(float damage)
    {
        Debug.Log("It... it works!?");
        EnemyReachedGoal(damage);
    }

    private void EnemyHasKill(float bounty)
    {
        EnemyKilled(bounty);
    }

    // Update is called once per frame
    void Update () {
        
	}
}
