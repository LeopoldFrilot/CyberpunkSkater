using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    public GameObject star;
    public float timeBetweenSpawns = 1f;
    private float curTime;

    private void Start()
    {
        curTime = timeBetweenSpawns * 2f + timeBetweenSpawns/2f;
    }
    // Update is called once per frame
    void Update()
    {
        if (curTime <= 0)
        {
            curTime = timeBetweenSpawns;
            Instantiate(star, transform);
        }
        curTime -= Time.deltaTime;
    }
}
