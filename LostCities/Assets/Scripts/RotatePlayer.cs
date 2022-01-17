using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    public bool facingRight = true;
    SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        
        var delta = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        if (delta.x >= 0 && !facingRight)
        {//Right
            spriteRenderer.flipX = false;
            facingRight = true;
        }
        else if (delta.x < 0 && facingRight)
        {//Left
            spriteRenderer.flipX = true;
            facingRight = false;
        }
    }

}
