﻿using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
    public Enemy _enemy;

    public GameObject CurrentTarget { get; set; }

    public void MoveTowardsTarget()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "tower")
        {
            //damage is handled in tower, just despawn
            Destroy(this.gameObject, .1f);
        }
    }

    void OnTriggerEnter()
    {

    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
