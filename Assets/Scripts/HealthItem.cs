using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour
{
    private int health = 800;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var damagable = collision.GetComponent<Damagable>();
        if (damagable != null)
        {
            damagable.Heal(health);
        }
        Destroy(gameObject);
    }
    
}
