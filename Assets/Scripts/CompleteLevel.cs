using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour
{
    private int level;
    private void Awake()
    {
        level = PlayerData.GetLevel();
    }
    public void Level1Complete()
    {
        if (level == 1)
        {
            level = 2;
        }
        PlayerData.SetLevel(level);
    }
    public void Level2Complete()
    {
        if (level == 2)
        {
            level = 3;
        }
        PlayerData.SetLevel(level);
    }
    public void Level3Complete()
    {
        if (level == 3)
        {
            level = 4;
        }
        PlayerData.SetLevel(level);
    }
}
