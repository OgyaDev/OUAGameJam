using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{

    private CollectionController collectionController;
    private KeyController keyController;
    private FriendController friendController;
    public GameObject hero;
    public GameObject key;
    public GameObject friend;
    public int doorGas = 5;
    

    private void Start()
    {
        collectionController = hero.GetComponent<CollectionController>();
        keyController = key.GetComponent<KeyController>();
        friendController = friend.GetComponent<FriendController>();
        key.SetActive(false);
        
    }

    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {

            if (keyController.IsKeyTaken)
            {
                friendController.DisplayDialog();
                Destroy(gameObject);
            }

            if (collectionController.Count >= doorGas && !keyController.IsKeyTaken)
            {

                collectionController.Count -= doorGas;
                key.SetActive(true);
            }
        }
    }
}
