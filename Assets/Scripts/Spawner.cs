using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    public float SpawnTime = 60;
    private float currentTime = 0;
    public GameObject ToBeSpawned;
    public Transform SpawnPoint;
     
    // Use this for initialization
    void Start () {
        currentTime = SpawnTime;
	}
	
	// Update is called once per frame
	void Update ()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            Debug.Log("Enemy Spawned");
            SpawnAsset();
            currentTime = SpawnTime ;
        }
    }

    public void SpawnAsset()
    {
        Instantiate(ToBeSpawned, SpawnPoint.localPosition, Quaternion.Euler(0, 160, 0));
    }
}
