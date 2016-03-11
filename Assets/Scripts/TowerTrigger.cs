using UnityEngine;
using System.Collections;

public class TowerTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            other.gameObject.GetComponent<Enemy>().EnemyGoal();
            //Destroy(other.gameObject, .1f);
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
