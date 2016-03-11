using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour {

    public Text TurretSelected;

    public string sel1 = "Turret   :  Bullet\nSelected";
    public string sel2 = "Turret   :  Fire\nSelected";
    public string sel3 = "Turret   :  Ice\nSelected";
    public string sel4 = "Turret   :  Acid\nSelected";
    public string sel5 = "Turret   :  Critical\nSelected";

    public Text scoreText;
    public Text goldText;
    public Text healthText;

    public GameObject tower;
    public GameObject player;

    // Use this for initialization
    void Start ()
    {
        healthText.text = string.Format("Tower Health: {0}",Tower.Health);
        goldText.text = string.Format("Gold :", Player.PlayerGold);
        scoreText.text = string.Format("Score :", Player.PlayerScore);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            TurretSelected.text = sel1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TurretSelected.text = sel2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            TurretSelected.text = sel3;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            TurretSelected.text = sel4;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            TurretSelected.text = sel5;
        }

        healthText.text = string.Format("Tower Health: {0}", Tower.Health);
        goldText.text = string.Format("Gold: {0}", Player.PlayerGold);
        scoreText.text = string.Format("Score: {0}", Player.PlayerScore);
    }
}
