using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    private bool isKeyTaken;
    public bool IsKeyTaken
    {
        get { return isKeyTaken; }
    }

    private void Start()
    {
        isKeyTaken = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isKeyTaken = true;
            gameObject.SetActive(false);
        }
    }
}
