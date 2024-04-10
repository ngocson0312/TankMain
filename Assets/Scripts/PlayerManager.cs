using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject gumdam;
    public GameObject iron;

    private int tankTry;
    private void Awake()
    {
        tankTry = PlayerData.GetTryTank();
    }
    private void Update()
    {
        if(tankTry == 2)
        {
            gumdam.SetActive(true);
        }
        else gumdam.SetActive(false);

        if(tankTry == 3)
        {
            iron.SetActive(true);
        }
        else iron.SetActive(false);
    }
}
