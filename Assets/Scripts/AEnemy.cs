using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AEnemy : MonoBehaviour
{
    [SerializeField]
    private int damage = 200;
    public UnityEvent OnHit;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            OnHit?.Invoke();
            var damagable = collision.gameObject.GetComponent<Damagable>();
            if (damagable != null)
            {
                damagable.Hit(damage);
            }
        }
    }
}
