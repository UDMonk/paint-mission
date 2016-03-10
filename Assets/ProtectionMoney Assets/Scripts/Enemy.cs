using UnityEngine;
using System.Collections;

public enum EnemyType { Goblin, Orc, Boss }

public delegate void EnemyKilledEventHandler(float bounty);
public delegate void TowerCollideEventHandler(float damage);

public class Enemy : MonoBehaviour {
    public event EnemyKilledEventHandler EnemyHasKill;
    public event TowerCollideEventHandler EnemyHasReachedGoal;

    public float GoalDamage;
    public float BountyAmount;
    float currentHealth { get; set; }
    public float MaxHealth;
    public float RunSpeed;

    public EnemyType Type;

    

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (currentHealth <= 0)
            {
                EnemyKilled();
            }
	}

    void EnemyKilled()
    {
        EnemyHasKill(BountyAmount);
    }
}
