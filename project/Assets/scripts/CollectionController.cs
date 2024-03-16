using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionController : MonoBehaviour
{
    [SerializeField] private static int count;
    public int Count
    {
        get { return count; }
    }
    [SerializeField] private AudioClip audioClip;

    private void Start()
    {
        count = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("collectible"))
        {
            count++;
            //AudioSource.PlayClipAtPoint(audioClip, collision.transform.position);
            Destroy(collision.gameObject);

        }
    }
}
