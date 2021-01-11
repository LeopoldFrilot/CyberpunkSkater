using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    int numLives;
    // Start is called before the first frame update
    void Start()
    {
        numLives = transform.childCount;
    }

    public void DecrimentLives()
    {
        if (numLives == 0) return;
        Destroy(transform.GetChild(numLives - 1).gameObject);
        numLives--;
        if(numLives == 0)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
