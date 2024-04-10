using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TankMover : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float maxSpeed = 1;
    public static bool pointerDown = false;
    public FixedJoystick joystick;
    private Vector2 movementVector;
    private Animator animator;
    public UnityEvent<float> OnMove = new UnityEvent<float>();

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }
    private void FixedUpdate()
    {
        Move();
        if (pointerDown)
        {
            rb.velocity = Vector3.zero;
        }
        else
        {
            rb.MovePosition(rb.position + movementVector * maxSpeed * Time.fixedDeltaTime);
        }
    } 
    private void Move()
    {
        movementVector = new Vector2(joystick.Horizontal, joystick.Vertical);
        float hAxis = movementVector.x;
        float vAxis = movementVector.y;
        float zAxis = Mathf.Atan2(hAxis, vAxis) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0f, 0f, -zAxis);

        float x = Mathf.Abs(joystick.Horizontal);
        float y = Mathf.Abs(joystick.Vertical);
        if (x >= y)
        {
            animator.SetFloat("speed", x);
        } else
        {
            animator.SetFloat("speed", y);
        }
        OnMove?.Invoke(movementVector.magnitude);
    }
}
