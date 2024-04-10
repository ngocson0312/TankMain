using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalRayPath : MonoBehaviour
{
	[SerializeField]
	private float speed = 1f;
	[SerializeField]
	private Rigidbody2D rigid;
	private EnemyAimTurret aimTurret;

	private void Start()
	{
		rigid = GetComponent<Rigidbody2D>();
		aimTurret = GetComponentInChildren<EnemyAimTurret>();
	}
	private void Update()
	{
		if (IsFacingRight())
		{
			rigid.velocity = new Vector2(speed, 0f);
			aimTurret.rayAim = 0;
		}
		else
		{
			rigid.velocity = new Vector2(-speed, 0f);
			aimTurret.rayAim = 180;
		}
	}

	private bool IsFacingRight()
	{
		return transform.localScale.x > Mathf.Epsilon;
	}
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.tag == "GameController")
		{
			transform.localScale = new Vector2(-(Mathf.Sign(rigid.velocity.x)), transform.localScale.y);
		}
	}

}
