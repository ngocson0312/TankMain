using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(ObjectPool))]
public class EnemyTurret : MonoBehaviour
{
    public TurretData turretData;
    public List<Transform> turretBarrels;
    private Collider2D enemyCollider;
    [SerializeField]
    private Collider2D pathCol;

    private bool canShoot = true;
    private float currentDelay = 0;

    private ObjectPool bulletPool;
    [SerializeField]
    private int bulletPoolCount = 10;
    private EnemyAimTurret enemyAim;

    [SerializeField]
    private float distance = 10;
    public UnityEvent OnShoot;

    private void Awake()
    {
        bulletPool = GetComponent<ObjectPool>();
        enemyAim = GetComponentInParent<EnemyAimTurret>();
        enemyCollider = GetComponentInParent<Collider2D>();
    }

    private void Start()
    {
        bulletPool.Initialize(turretData.bulletPrefab, bulletPoolCount);
    }

    private void Update()
    {
        Shoot();
        if (canShoot == false)
        {
            currentDelay -= Time.deltaTime;
            if (currentDelay <= 0)
            {
                canShoot = true;
            }
        }
        if (enemyAim.col != null)
        {
            distance = Vector2.Distance(transform.position, enemyAim.PlayerPos);
        } else
        {
            distance = 20;
        }
    }

    private void Shoot()
    {
        if (canShoot && distance < turretData.bulletData.maxDistance)
        {
            canShoot = false;
            currentDelay = turretData.reloadDelay;

            foreach (var barrel in turretBarrels)
            {
                GameObject bullet = bulletPool.CreateObject();
                bullet.transform.position = barrel.position;
                bullet.transform.localRotation = barrel.rotation;
                bullet.GetComponent<Bullet>().Initialize(turretData.bulletData);
                Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), enemyCollider);
                if (pathCol != null)
                {
                    Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), pathCol);
                }
                OnShoot?.Invoke();
            }
        }
    }
}
