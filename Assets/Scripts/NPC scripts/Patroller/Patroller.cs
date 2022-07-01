using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour
{
    [SerializeField] public Transform[] waypoints;
    public int speed;

    private int waypointIndex;
    private float dist;

    public bool PlayerInRange = false;
    public float playerdetectionRange = 0.9f;

    public LayerMask playerMask;
    public Transform PlayerCheck;


    void Start()
    {
        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);
    }

    void Update()
    {
        dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if (dist < 1f)
        {
            IncreaseIndex();
        }
        Patrol();

        PlayerInRange = Physics.CheckSphere(PlayerCheck.position, playerdetectionRange, playerMask);

        if (PlayerInRange == true)
        {
            speed = 0;
        }
        if (PlayerInRange == false)
        {
            speed = 4;
        }
    }

        void Patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void IncreaseIndex()
    {
        waypointIndex++;
        if (waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
        transform.LookAt(waypoints[waypointIndex].position);
    }    
}
