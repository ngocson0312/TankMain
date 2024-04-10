using System.Collections;
using UnityEngine;

public class EnemyAimTurret : MonoBehaviour
{
    [SerializeField]
    private float checkRadius;
    public LayerMask playerMask;
    private Vector2 playerPos;
    public Collider2D col = null;
    [SerializeField]
    private float delay = 0.1f;
    public float rayAim = 0;

    public Vector2 PlayerPos
    {
        get
        {
            return playerPos;
        }
    }
    private void Update()
    {
        StartCoroutine(DelayGetPlayerPos());
        Aim();
    }

    public void Aim()
    {
        Vector2 direction = (Vector3)playerPos - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.eulerAngles = new Vector3(0f, 0f, angle-rayAim);
    }
    public void GetPlayerPos()
    {
        col = Physics2D.OverlapCircle(transform.position, checkRadius, playerMask);
        if (col != null)
        {
            playerPos = col.transform.position;
        }
    }
    IEnumerator DelayGetPlayerPos()
    {
        yield return new WaitForSeconds(delay);
        GetPlayerPos();
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }
}
