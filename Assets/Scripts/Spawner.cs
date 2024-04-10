using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject appearAffect;

    public void Enemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.Euler(0,0,-90));
    }
    public void Appear()
    {
        Instantiate(appearAffect, transform.position, Quaternion.identity);
    }
    public void SpawnEnemy()
    {
        Invoke("Enemy", 1.4f);
    }
    public void SpawnAppear()
    {
        Invoke("Appear", 1f);
    }
}
