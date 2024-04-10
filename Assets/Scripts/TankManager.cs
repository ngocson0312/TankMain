using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankManager : MonoBehaviour
{
    public GameObject skyfall;
    public GameObject gumdam;
    public GameObject iron;

    private int selectTank;
    private void Awake()
    {
        selectTank = PlayerData.GetSelectTank();
    }
    private void Update()
    {
        if(selectTank == 1 && skyfall != null)
        {
            skyfall.SetActive(true);
        }
        if(selectTank != 1)
            skyfall.SetActive(false);

        if (selectTank == 2 && gumdam != null)
        {
            gumdam.SetActive(true);
        }
        if(selectTank != 2)
            gumdam.SetActive(false);

        if (selectTank == 3 && iron != null)
        {
            iron.SetActive(true);
        }
        if (selectTank !=3)
            iron.SetActive(false);
    }
}
