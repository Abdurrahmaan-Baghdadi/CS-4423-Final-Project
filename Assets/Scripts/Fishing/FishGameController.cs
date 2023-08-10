using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class FishGameController : MonoBehaviour
{
    public GameObject prefabGarbage;
    public int numObstacles = 4;
    public static FishGameController fishGameController = null;

    public GameObject prefabFish;
    public float pauseTimeFish = 3f;

    public float pauseTimeObstacle = 1f;


    void Awake()
    {
        if(fishGameController == null)
        {
            fishGameController = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numObstacles; i++)
            StartCoroutine(SpawnObstacle(.85f*i));
        StartCoroutine(SpawnFish(3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstacle(float delay)
    {
        yield return new WaitForSeconds(delay);
        while(true)
        {
            Vector3 spawnLoc = new Vector3(Random.Range(-7,7), 4.5f, 0);
            GameObject newObstacle = Instantiate(prefabGarbage, spawnLoc, Quaternion.identity);
            Destroy(newObstacle, 2);
            yield return new WaitForSeconds(pauseTimeObstacle);
        }
        //yield return null;
    }
    IEnumerator SpawnFish(float fishDelay)
    {
        yield return new WaitForSeconds(fishDelay);
        while(true)
        {
            Vector3 fishSpawnLoc = new Vector3(Random.Range(-7,7), 4.5f, 0);
            GameObject newFish = Instantiate(prefabFish, fishSpawnLoc, Quaternion.identity);
            Destroy(newFish, 2);
            yield return new WaitForSeconds(pauseTimeFish);
        }
    }
}
