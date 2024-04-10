using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayPath : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    private Rigidbody2D rigid;
    public Transform barrel;

    private bool canRotate = true;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (IsFacingUp())
        {
            speed = 1f;
            rigid.velocity = new Vector2(0f, speed);
        }
        else
        {
            speed = -1f;
            rigid.velocity = new Vector2(0f, speed);
        }
        if (speed > 0f)
        {
            if (canRotate)
            {
                canRotate = false;
                barrel.transform.Rotate(0, 0, 180, Space.Self);
            }
        }
        else if (speed < 0f)
        {
            if (canRotate == false)
            {
                barrel.transform.Rotate(0, 0, 180, Space.Self);
                canRotate = true;
            }
        }
    }
    private bool IsFacingUp()
    {
        if (transform.localScale.y > 0)
            return true;
        else return false;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "GameController")
        {
            transform.localScale = new Vector2(transform.localScale.x, -transform.localScale.y);
        }
    }
}
