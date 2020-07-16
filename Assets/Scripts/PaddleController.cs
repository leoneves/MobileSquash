using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float moveSpeed;

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    // calls each 0.02 seconds based on Time.fixedDeltaTime
    private void FixedUpdate()
    {
        TouchMove();
    }

    void TouchMove()
    {
        // 0 = to left button
        // 1 = to right button
        // 2 = to middle button
        if (Input.GetMouseButton(0))
        {
            // ScreenToWorldPoint transform screen position pixels in units position
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (touchPos.x < 0)
            {
                rb.velocity = Vector2.left * moveSpeed;
            }
            else
            {
                rb.velocity = Vector2.right * moveSpeed;
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
