using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyBossAI : MonoBehaviour
{

    public Transform Target;
    public float speed = 200f;
    public float nextWaypointDistance = 3.0f;

    Path Path;
    int CurrentWaypoint = 0;
    bool reachedEndOfPath = false;

    Seeker Seeker;
    Rigidbody2D rb;
        
        void Start()
    {
        Seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        Seeker.StartPath(rb.position, Target.position, OnPathComplete);
    }
    void OnPathComplete(Path p)
    {
        if(!p.error)
        {
            Path = p;
            CurrentWaypoint = 0;
        }
    }

    // Update is called once per frame
    void fixedUpdate()
    {
        if (Path == null) return;

        if (CurrentWaypoint >= Path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        }
        else
        {
            reachedEndOfPath = false;
        }

        Vector2 direction = ((Vector2)Path.vectorPath[CurrentWaypoint]- rb.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;

        rb.AddForce(force);

        float distance = Vector2.Distance(rb.position, Path.vectorPath[CurrentWaypoint]);
        if(distance <=nextWaypointDistance)
        {
            CurrentWaypoint++;
        }
    }
}
