using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float timeBetweenSpawns = 2f;
    private float curTime;

    private void Start()
    {
        curTime = timeBetweenSpawns * 2;
    }
    // Update is called once per frame
    void Update()
    {
        if(curTime <= 0)
        {
            curTime = timeBetweenSpawns;
            Instantiate(obstacle, transform);
            if(Random.Range(0f,1f) > 0.5f) // 20% chance to spawn two
            {
                Instantiate(obstacle, transform);
            }
        }
        curTime -= Time.deltaTime; 
    }
}
