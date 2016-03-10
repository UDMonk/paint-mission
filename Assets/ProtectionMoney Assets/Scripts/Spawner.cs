using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    float timer = 10;
    public GameObject ToBeSpawned;
    public Transform SpawnPoint;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        if (timer == 0 || timer < 0)
        {
            Debug.Log("Timer reached 0");
            SpawnAsset();
            timer = 1;
        }
    }

    public void SpawnAsset()
    {
        Instantiate(ToBeSpawned, SpawnPoint.localPosition, Quaternion.Euler(0, 160, 0));
    }
}
