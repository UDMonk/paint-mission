using UnityEngine;
using System.Collections;

public class SpawnObjectOnClick : MonoBehaviour {

    public GameObject BulletTurret;
    public GameObject FireTurret;
    public GameObject IceTurret;
    public GameObject AcidTurret;
    public GameObject CriticalTurret;

    //public GameObject SelectedTurret;

    public Player PlayerScript;

    int selectedTurret;

    // Use this for initialization
    void Start ()
    {
        selectedTurret = 1;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedTurret = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedTurret = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selectedTurret = 3;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            selectedTurret = 4;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            selectedTurret = 5;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if(selectedTurret == 1)
            {
                if (PlayerScript.PlayerGold >= 50)
                {
                    Ray ray;
                    RaycastHit hit;
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit, 100.0f))
                    {
                        if (hit.collider.tag == "spawnEnabled")
                            Instantiate(BulletTurret, hit.point, Quaternion.identity);
                    }
                    PlayerScript.PlayerGold -= 50;
                }
            }
            if (selectedTurret == 2)
            {
                if (PlayerScript.PlayerGold >= 150)
                {
                    Ray ray;
                    RaycastHit hit;
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit, 100.0f))
                    {
                        if (hit.collider.tag == "spawnEnabled")
                            Instantiate(FireTurret, hit.point, Quaternion.identity);
                    }
                    PlayerScript.PlayerGold -= 150;
                }
            }
            if (selectedTurret == 3)
            {
                if (PlayerScript.PlayerGold >= 150)
                {
                    Ray ray;
                    RaycastHit hit;
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit, 100.0f))
                    {
                        if (hit.collider.tag == "spawnEnabled")
                            Instantiate(IceTurret, hit.point, Quaternion.identity);
                    }
                    PlayerScript.PlayerGold -= 150;
                }
            }
            if (selectedTurret == 4)
            {
                if (PlayerScript.PlayerGold >= 255)
                {
                    Ray ray;
                    RaycastHit hit;
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit, 100.0f))
                    {
                        if (hit.collider.tag == "spawnEnabled")
                            Instantiate(AcidTurret, hit.point, Quaternion.identity);
                    }
                    PlayerScript.PlayerGold -= 255;
                }
            }
            if (selectedTurret == 5)
            {
                if (PlayerScript.PlayerGold >= 300)
                {
                    Ray ray;
                    RaycastHit hit;
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit, 100.0f))
                    {
                        if (hit.collider.tag == "spawnEnabled")
                            Instantiate(CriticalTurret, hit.point, Quaternion.identity);
                    }
                    PlayerScript.PlayerGold -= 300;
                }
            }

        }
    }
}
