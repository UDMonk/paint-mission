using UnityEngine;
using System.Collections;
using System;

public class EventManager : MonoBehaviour
{
    public GameObject baseEnemy; //listen for events triggered in enemy classes
    public event EnemyKilledEventHandler EnemyKilled;
    public event TowerCollideEventHandler EnemyReachedGoal;

    // Use this for initialization
    void Start ()
    {
        baseEnemy.GetComponent<Enemy>().EnemyHasKill += new EnemyKilledEventHandler(EventManager_EnemyHasKill);
        baseEnemy.GetComponent<Enemy>().EnemyHasReachedGoal += new TowerCollideEventHandler (EventManager_EnemyHasReachedGoal);
    }

    private void EventManager_EnemyHasReachedGoal(float damage)
    {
        EnemyReachedGoal(damage);
    }

    private void EventManager_EnemyHasKill(float bounty)
    {
        EnemyKilled(bounty);
    }

    // Update is called once per frame
    void Update () {
        
	}
}
