using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using System;

public class AEnemyAI : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    public float nextWPdistance = 6f;
    private Seeker seeker;
    private Transform playerPos;
    private int currentWP = 0;
 // bool isReached = false;
    Path path;

    private void Start()
    {
        seeker = gameObject.GetComponent<Seeker>();
        playerPos = FindObjectOfType<TankMover>().gameObject.transform;
        InvokeRepeating("UpDatePath", 0f, 0.5f);
    }
    private void FixedUpdate()
    {
        if (path == null) return;

        if(currentWP >= path.vectorPath.Count)
        {
          //  isReached = true;
            return;
        }
        /* else
        {
            isReached = false;
        } */
        transform.position = Vector2.MoveTowards(transform.position, (Vector2)path.vectorPath[currentWP], speed * Time.fixedDeltaTime);
        float distance = Vector2.Distance(transform.position, path.vectorPath[currentWP]);
        if (distance <= nextWPdistance)
        {
            currentWP++;
        }   
    }
    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWP = 0;
        }   
    }
    void UpDatePath()
    {
        if (seeker.IsDone())
        {
            seeker.StartPath(transform.position, playerPos.position, OnPathComplete);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, nextWPdistance);
    }
}
