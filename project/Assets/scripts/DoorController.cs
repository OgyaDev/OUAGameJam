using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{

    CollectionController collectionController;
    public GameObject hero;

    private void Start()
    {
        collectionController = hero.GetComponent<CollectionController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log(collectionController.Count);
            if (collectionController.Count != 0 && collectionController.Count % 5 == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
