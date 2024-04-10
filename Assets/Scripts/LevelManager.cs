using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject lock1;
    public GameObject lock2;
    public GameObject lock3;

    private int level;
    private void Awake()
    {
        level = PlayerData.GetLevel();
    }
    private void Update()
    {
        if (level >= 2)
        {
            lock1.SetActive(false);
        }
        if (level >= 3)
        {
            lock2.SetActive(false);
        }
        if (level >= 4)
        {
            lock3.SetActive(false);
        }
    }
}
