﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

public enum EnemyType { Goblin, Orc, Boss }

public delegate void EnemyKilledEventHandler(float bounty);
public delegate void TowerCollideEventHandler(float damage);

public class Enemy : MonoBehaviour {
    public event EnemyKilledEventHandler EnemyHasKill;
    public event TowerCollideEventHandler EnemyHasReachedGoal;

    public float GoalDamage;
    public float BountyAmount;
    public float currentHealth { get; set; }
    public float MaxHealth;

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
        if(EnemyHasKill != null)
            EnemyHasKill(BountyAmount);
    }

    public void EnemyGoal()
    {
        if(EnemyHasReachedGoal != null)
        {
            EnemyHasReachedGoal(GoalDamage);
            Debug.Log("...Work?");
        }
    }
}
