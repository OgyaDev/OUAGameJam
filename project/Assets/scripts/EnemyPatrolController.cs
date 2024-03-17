using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolController : MonoBehaviour
{

    public GameObject pointA;
    public GameObject pointB;
    public GameObject pointC;
    public float speed;
    private Rigidbody2D rb;
    private Transform currentPoint;
    private Transform targetPoint;
    private Stack<Transform> road;
    private Stack<Transform> tempRoad;
    private bool direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointA.transform;
        targetPoint = pointB.transform;
        tempRoad = new Stack<Transform>(3);
        road = new Stack<Transform>(3);
        road.Push(pointC.transform);
        tempRoad.Push(pointA.transform);
        tempRoad.Push(pointB.transform);
    }

    private void FixedUpdate()
    {

        if (currentPoint.transform.position.x == targetPoint.transform.position.x)
        {
            if(currentPoint.transform.position.y > targetPoint.transform.position.y)
            {
                rb.velocity = new Vector2(0, -speed * Time.deltaTime);
                Debug.Log("x3");

            }
            else
            {
                rb.velocity = new Vector2(0, speed * Time.deltaTime);
                Debug.Log("x4");


            }
        }

        if (currentPoint.transform.position.y == targetPoint.transform.position.y)
        {
            if (currentPoint.transform.position.x > targetPoint.transform.position.x)
            {
                rb.velocity = new Vector2(-speed * Time.deltaTime, 0);
                Debug.Log("x5");

            }
            else
            {
                rb.velocity = new Vector2(speed * Time.deltaTime,0);
                Debug.Log("x6");


            }
        }

        if (Vector2.Distance(transform.position, targetPoint.position) < 0.1f)
        {
            currentPoint = targetPoint;
            if (direction)
            {
                targetPoint = road.Pop();
                tempRoad.Push(targetPoint);
                Debug.Log("x1");
            }
            else
            {
                targetPoint = tempRoad.Pop();
                road.Push(targetPoint);
                Debug.Log("x2");

            }
        }
    }

    void Update()
    {

    }
}
