using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour
{
    float towerHealth;
    public GameObject GameController;

    // Use this for initialization
    void Start () {
        towerHealth = 1000;
        GameController.GetComponent<EventManager>().EnemyReachedGoal += Tower_EnemyReachedGoal;
    }

    private void Tower_EnemyReachedGoal(float damage)
    {
        towerHealth -= damage;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
