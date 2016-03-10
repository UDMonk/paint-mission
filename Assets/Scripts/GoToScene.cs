using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour {

    public string levelName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadIndicatedScene()
    {
        SceneManager.LoadScene(levelName);
    }
}
