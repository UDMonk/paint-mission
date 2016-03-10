using UnityEngine;
using System.Collections;

public enum EnemyType { Goblin, Orc, Boss }

public class Enemy : MonoBehaviour {
    public float GoalDamage;
    public float BountyAmount;
    float currentHealth { get; set; }
    public float MaxHealth;
    public float RunSpeed;

    public EnemyType Type;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
