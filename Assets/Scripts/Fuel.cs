using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    private PlayerController PC;

    public float xMoveSpeed;
    public float perspectiveScale = .3f;
    public float obstacleOffset = .1f;
    public float scoreChangeForTouch;

    // Lane logic
    private float maxHeight;
    private float minHeight;
    private float laneWidth;
    private int curLane;
    private Vector3 defaultScale;

    private void Start()
    {
        defaultScale = transform.localScale;
        PC = FindObjectOfType<PlayerController>();
        maxHeight = PC.maxHeight + obstacleOffset;
        minHeight = PC.minHeight - obstacleOffset;
        laneWidth = (maxHeight - minHeight) / (PC.laneNum - 1);
        SetLane(Random.Range(1, 4));
        
        GetComponent<Collider2D>().offset += new Vector2(transform.GetChild(0).localPosition.x, transform.GetChild(0).localPosition.y);
        
    }
    
    private void Update()
    {
        transform.position = new Vector3(transform.position.x + PC.AC.speed * xMoveSpeed * Time.deltaTime, transform.position.y);
    }
    
    public void SetLane(int num)
    {
        transform.position = new Vector3(transform.position.x, maxHeight - num * laneWidth);
        curLane = num;
        string name = "Lane" + num + " Foreground";

        gameObject.layer = 7 + num;
        transform.GetChild(0).gameObject.layer = 7 + num;
        for (int i = 0; i < transform.GetChild(0).childCount; i++)
        {
            transform.GetChild(0).GetChild(i).gameObject.layer = 7 + num; // Sets physics layer
            transform.GetChild(0).GetChild(i).GetComponent<SpriteRenderer>().sortingLayerName = name;
        }
        
        UpdateScale();
        
    }
    
    private void UpdateScale()
    {
        transform.localScale = new Vector3(defaultScale.x + curLane * perspectiveScale, defaultScale.y + curLane * perspectiveScale);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var playerCount = collision.transform.GetComponentsInParent<PlayerController>().Length;

        if (playerCount > 0)
        {
            var player = collision.transform.parent.GetComponent<PlayerController>();
            if(player.CollectFuel(gameObject, curLane))
            {
                FindObjectOfType<ScoreTracker>().AddToScore(scoreChangeForTouch);
                FindObjectOfType<FuelDisplay>().AddFuel();
            }
        }
    }

}
