using UnityEngine;
using System.Collections;

///

public class WaveController : MonoBehaviour {

    /* Each wave has three arrays, one for each of the enemy types (0,1,2; goblin,orc,boss;) all in a 'wave' array
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
    PMWave waves;
    int thisWave;
    int[] currentWave;
    int currentType;
    int maxEnemies;
    int currentEnemies;
    int enemiesRemaining;
    float waveDelayTimer = 50;
    float monSpawnDelay;
    System.Random r = new System.Random();
    int ran;
    public float PlayerGold { get; set; }

    #region Spawners
    public GameObject Spawner01;
    public GameObject Spawner02;
    public GameObject Spawner03;
    public GameObject Spawner04;
    public GameObject Spawner05;
    #endregion

    //public GameObject eventManager;

    // Use this for initialization
    void Start ()
    {
        waves = new PMWave();
        thisWave = 1;
        currentWave = waves.wave01;
        enemiesRemaining = 0;
        enemiesRemaining += (currentWave[0] + currentWave[1] + currentWave[2]);
        maxEnemies = 6;
        currentType = 0;
        monSpawnDelay = 0;

        //catch events here:
        gameObject.GetComponent<EventManager>().EnemyKilled += new EnemyKilledEventHandler (EventManager_EnemyKilled);
    }

    private void EventManager_EnemyKilled(float bounty)
    {
        currentEnemies -= 1;
        enemiesRemaining -= 1;
    }

    // Update is called once per frame
    void Update ()
    {
        if(!LevelOver())
        {
            if(currentEnemies == 0 && enemiesRemaining == 0)
            {
                NextWave();
            }
            else
            {
                waveDelayTimer -= Time.deltaTime;

                if (currentWave[currentType] == 0)
                {
                    currentType++;
                }

                if (waveDelayTimer <= 0)
                {
                    monSpawnDelay -= Time.deltaTime;
                    if (currentWave[currentType] < 6)
                        maxEnemies = 3;
                    else
                        maxEnemies = 6;

                    if (currentEnemies != maxEnemies && monSpawnDelay <= 0 && enemiesRemaining > 0)
                    {
                        if (currentEnemies != enemiesRemaining)
                        // Check that the number of enemies on the field is not equal to the number of enemies remaining, to prevent more enemies from being spawned.
                        {
                            ran = r.Next(1, 3);
                            if (ran == 1 || ran == 2)
                            {
                                if (currentType == 0)
                                    Spawner01.GetComponent<Spawner>().SpawnAsset();
                                if (currentType == 1)
                                    Spawner03.GetComponent<Spawner>().SpawnAsset();
                                if (currentType == 2)
                                    Spawner05.GetComponent<Spawner>().SpawnAsset();
                                monSpawnDelay = 5;
                                currentEnemies++;
                            }

                            else if (ran == 3)
                            {
                                if (currentType == 0)
                                    Spawner02.GetComponent<Spawner>().SpawnAsset();
                                if (currentType == 1)
                                    Spawner04.GetComponent<Spawner>().SpawnAsset();
                                if (currentType == 2)
                                    Spawner05.GetComponent<Spawner>().SpawnAsset();
                                monSpawnDelay = 5;
                                currentEnemies++;
                            }
                        }

                    }
                }
            }
            

            
        }

        else
        {
            //Make go back to main menu later
            Application.Quit();
        }
	}

    void NextWave()
    {
        if (thisWave == 4)
        {
            thisWave = 5;
            currentWave = waves.wave05;
            waveDelayTimer = 50;
            enemiesRemaining = 0;
            enemiesRemaining += (currentWave[0] + currentWave[1] + currentWave[2]);
        }
        if (thisWave == 3)
        {
            thisWave = 4;
            currentWave = waves.wave04;
            waveDelayTimer = 50;
            enemiesRemaining = 0;
            enemiesRemaining += (currentWave[0] + currentWave[1] + currentWave[2]);
        }
        if (thisWave == 2)
        {
            thisWave = 3;
            currentWave = waves.wave03;
            waveDelayTimer = 50;
            enemiesRemaining = 0;
            enemiesRemaining += (currentWave[0] + currentWave[1] + currentWave[2]);
        }
        if (thisWave == 1)
        {
            thisWave = 2;
            currentWave = waves.wave02;
            waveDelayTimer = 50;
            enemiesRemaining = 0;
            enemiesRemaining += (currentWave[0] + currentWave[1] + currentWave[2]);
        }
    }

    bool LevelOver()
    {
        if (thisWave == 5 && enemiesRemaining == 0)
            return true;
        else
            return false;
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
