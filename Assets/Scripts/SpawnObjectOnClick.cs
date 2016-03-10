using UnityEngine;
using System.Collections;

public class SpawnObjectOnClick : MonoBehaviour {

    public GameObject ToBeSpawned;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray;
            RaycastHit hit;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.collider.tag == "spawnuponable")
                    Instantiate(ToBeSpawned, hit.point, Quaternion.identity);
            }
        }
    }
}
