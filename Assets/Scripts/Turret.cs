using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(ObjectPool))]
public class Turret : MonoBehaviour
{
    public TurretData turretData;
    public Transform turretBarrel;
    private Collider2D tankCollider;
    private bool canShoot = true;
    private float currentDelay = 0;

    private ObjectPool bulletPool;
    [SerializeField]
    private int bulletPoolCount = 10;
    private AimTurret aimTurret;

    private float distance = 10;
    public UnityEvent OnShoot;

    private void Awake()
    {
        bulletPool = GetComponent<ObjectPool>();
        aimTurret = GetComponentInParent<AimTurret>();
        tankCollider = GetComponentInParent<Collider2D>();
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
        if (aimTurret.closestEnemy != null)
        {
            distance = Vector2.Distance(transform.position, aimTurret.closestEnemy.transform.position);
        }
        else
        {
            canShoot = false;
        }
    }

    private void Shoot()
    {
       if (canShoot && distance < turretData.bulletData.maxDistance)
        {
            canShoot = false;
            currentDelay = turretData.reloadDelay;

            GameObject bullet = bulletPool.CreateObject();
            bullet.transform.position = turretBarrel.position;
            bullet.transform.localRotation = turretBarrel.rotation;
            bullet.GetComponent<Bullet>().Initialize(turretData.bulletData);
            Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), tankCollider);

            OnShoot?.Invoke();
        }
    }
}
