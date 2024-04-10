using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTurret : MonoBehaviour
{
    [SerializeField]
    private float checkRadius;
    public LayerMask enemyMask;
    private Vector2 target;
    public Collider2D closestEnemy = null;

    private void Update()
    {
        GetClosest();
        Aim();
    }

    public void Aim ()
    {
        Vector2 direction = (Vector3)target - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.eulerAngles = new Vector3(0f, 0f, angle);
    }
    public void GetClosest()
    {
        float distanceToClosestEnemy = Mathf.Infinity;

        Collider2D[] cols = Physics2D.OverlapCircleAll(transform.position, checkRadius, enemyMask);

        foreach (Collider2D enemy in cols)
        {
            float distanceToEnemy = (enemy.transform.position - this.transform.position).sqrMagnitude;
            if (distanceToEnemy < distanceToClosestEnemy)
            {
                distanceToClosestEnemy = distanceToEnemy;
                closestEnemy = enemy;
            }
        }
        if (closestEnemy == null)
        {
            target = transform.position + Vector3.up;
        }
        else
        {
            target = closestEnemy.transform.position;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }
}

