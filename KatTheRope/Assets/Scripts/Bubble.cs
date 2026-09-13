using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    private Rigidbody2D rb;

    public float gravityScaleValue = 0.1f;
    public GameObject ball;

    private Renderer objectRenderer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        objectRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Ball")
        {
            liftBubble();
        }

        if (other.name == "Cutter")
        {
            destroyBubble();
        }
    }
    private void liftBubble()
    {
        rb.gravityScale = -gravityScaleValue;

        ball.GetComponent<Rigidbody2D>().velocity = new Vector2(rb.velocity.x, 0);
        ball.GetComponent<Rigidbody2D>().transform.position = transform.position;
        ball.GetComponent<Rigidbody2D>().gravityScale = rb.gravityScale;

    }

    private void destroyBubble()
    {
        objectRenderer.enabled = false;
        ball.GetComponent<Rigidbody2D>().gravityScale = 0.55f;
        Destroy(this);
    }
}
