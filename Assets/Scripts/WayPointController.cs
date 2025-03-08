using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointController : MonoBehaviour
{
    // This script is borrowed from https://youtu.be/ExRQAEm4jPg?si=__QhPinGyFFKy8a1

    [SerializeField]
    Transform[] wayPoints;

    public float moveSpeed;

    int waypointIndex;
    // Start is called before the first frame update
    void Start()
    {
        waypointIndex = 0;

        transform.position = wayPoints [waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[waypointIndex].transform.position, moveSpeed);

        if (transform.position == wayPoints[waypointIndex].transform.position)
        {
            waypointIndex++;
        }

        if (waypointIndex == wayPoints.Length)
        {
            waypointIndex = 0;
        }
    }
}
