using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerator : MonoBehaviour
{
    // public connections
    GameManager GM;

    // public fields
    public float passiveAccelerationRate = .005f;

    // private fields
    public float speed = .05f;

    private void Start()
    {
        GM = FindObjectOfType<GameManager>();
    }
    void Update()
    {
        PassiveAcceleration();
        //float offset = Time.deltaTime * speed + GM.background.material.GetTextureOffset("_MainTex").x;
        //GM.background.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
    public void AlterSpeed(float val)
    {
        speed += val;
    }
    private void PassiveAcceleration()
    {
        AlterSpeed(passiveAccelerationRate * Time.deltaTime);
    }
}
