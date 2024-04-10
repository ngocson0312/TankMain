using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Skill : MonoBehaviour
{
    private Vector2 startPosition;
    private float conquaredDistance = 0;
    private Rigidbody2D rb2d;
    private float maxdistance = 12;
    [SerializeField]
    private int damage = 450;

    public UnityEvent OnSkill = new UnityEvent();

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void Initialize()
    {
        startPosition = transform.position;
        rb2d.velocity = transform.up * 5;
    }
    private void Update()
    {
        conquaredDistance = Vector2.Distance(transform.position, startPosition);
        if (conquaredDistance >= maxdistance)
        {
            DisableObject();
        }
    }

    private void DisableObject()
    {
        rb2d.velocity = Vector2.zero;
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnSkill?.Invoke();
        var damagable = collision.GetComponent<Damagable>();
        if (damagable != null)
        {
            damagable.Hit(damage);
        }
        DisableObject();
    }
}
