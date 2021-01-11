using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilityFlash : MonoBehaviour
{
    public float time;
    SpriteRenderer sprite;
    public float timeForFlash;
    private float curTimeForFlash;
    public float flashAlpha = .2f;
    private Color defaultColor;
    private void Start()
    {
        sprite = transform.GetComponent<SpriteRenderer>();
        defaultColor = sprite.color;
    }
    public void Update()
    {
        if(time > 0)
        {
            if(curTimeForFlash <= 0)
            {
                if(sprite.color.a == flashAlpha)
                {
                    defaultColor.a = 1f;
                }
                else
                {
                    defaultColor.a = flashAlpha;
                }
                sprite.color = defaultColor;
                curTimeForFlash = timeForFlash;
            }
            curTimeForFlash -= Time.deltaTime;
            time -= Time.deltaTime;
        }
        else
        {
            defaultColor.a = 1f;
            sprite.color = defaultColor;
        }
    }
    public void StartFlash(float num)
    {
        time = num;
        curTimeForFlash = 0;
    }
    public bool IsInvincible()
    {
        if(time > 0)
        {
            return true;
        }
        return false;
    }
}
