using UnityEngine;
using System.Collections;

public class WaveController : MonoBehaviour {

    /*waves. Each wave has three arrays, one for each of the enemy types (0,1,2; goblin,orc,boss;) all in a 'wave' array
    *            0  1  2
    * (0)Wave 1: 5  0  0
    * (1)Wave 2: 10 0  0
    * (2)Wave 3: 10 5  0
    * (3)Wave 4: 20 10 0
    * (4)Wave 5: 0  0  1
    *
    * Game starts, level index of 0, so Wave 1.
    * When a wave starts it goes through the wave array, starting at the index 0, which contains an int. This int represents the number of that enemy type in the wave.
    * each time one of those enemies is spawned, the int decreases by one until it reaches 0. then the wave array's index is increased by one.
    * When all enemies are dead, the next wave is started,increasing the level array index by one
    */
    int[] currentWave;
    
    //events are created and broadcasted in other controllers, caught with this controller

	// Use this for initialization
	void Start () {
        PMWave thisWave = new PMWave();
        currentWave = thisWave.wave01;
        
        //catch events here:
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public class PMWave
    {
        public int[] wave01 = new int[] { 5, 0, 0 };
        public int[] wave02 = new int[] { 10, 0, 0 };
        public int[] wave03 = new int[] { 10, 5, 0 };
        public int[] wave04 = new int[] { 20, 10, 0 };
        public int[] wave05 = new int[] { 0, 0, 1 };
    }
}
