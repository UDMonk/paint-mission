using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour
{
    public static float Health = 1000;
    public GameObject GameController;

    void Start () {
        //GameController.GetComponent<EventManager>().EnemyReachedGoal += Tower_EnemyReachedGoal;
    }

   void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Contains("enemy"))
        {
            var enemyComp = collision.gameObject.GetComponent<Enemy>();
            if(enemyComp != null)
            {
                Health -= enemyComp.GoalDamage;

                Player.PlayerGold += enemyComp.BountyAmount;
                Player.EnemiesKilled++;

                GameObject.Destroy(collision.gameObject);
            }
        }
    }
}
