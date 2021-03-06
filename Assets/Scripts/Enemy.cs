﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

public enum EnemyType { Goblin, Orc, Boss }

public delegate void EnemyKilledEventHandler(float bounty);
public delegate void TowerCollideEventHandler(float damage);

public class Enemy : MonoBehaviour {
    public event EnemyKilledEventHandler EnemyHasKill;
    public event TowerCollideEventHandler EnemyHasReachedGoal;

    public float GoalDamage =10;
    public float BountyAmount =50;
    public float currentHealth = 100;
    public float MaxHealth =100;

    public EnemyType Type;

    //public Transform pointA;
    //public Transform pointB;

    // Use this for initialization
    void Start ()
    {
        currentHealth = MaxHealth;

	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (currentHealth <= 0)
            {
                EnemyKilled();
            }
	}

    public void EnemyKilled()
    {
        //This doesn't work, line below it is doing its job
        //if(EnemyHasKill != null)
        //    EnemyHasKill(BountyAmount);

        Player.EnemiesKilled++;
        Player.PlayerGold += BountyAmount;
        Player.PlayerScore += BountyAmount;
        //Destroy(this.gameObject);
        DestroyObject(gameObject);
    }

    public void EnemyGoal()
    {
        if(EnemyHasReachedGoal != null)
        {
            EnemyHasReachedGoal(GoalDamage);
            Debug.Log("...Work?");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.ToLower().Contains("bullet"))
        {
            //Everyone's too busy to help so i'll have to make all bullets do the same amount of damage
            Debug.Log("Hit Confirmed");
            currentHealth -= 10;
            GameObject.Destroy(collision.gameObject);
        }
    }
}
