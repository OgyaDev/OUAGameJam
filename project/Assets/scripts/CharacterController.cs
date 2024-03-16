using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float speed = 1.0f;

    private Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigidbody2D.velocity = new Vector2(
            Input.GetAxis("Horizontal") * speed * Time.deltaTime,
            Input.GetAxis("Vertical") * speed * Time.deltaTime);
    }

    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            Debug.Log("gameOver");
        }
    }
}
