using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Animator animator;
    private Collider2D myCollider;
    void Start()
    {
        animator = GetComponent<Animator>();

        if (animator == null)
        {
            Debug.LogError("Animator bulunamadı: " + gameObject.name);
        }

        myCollider = GetComponent<Collider2D>();

        if (myCollider == null)
        {
            Debug.LogError("Collider2D bulunamadı" + gameObject.name);
        }
    }

    void OsionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            myCollider.enabled = false;
            animator.SetTrigger("BiteCollision");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
