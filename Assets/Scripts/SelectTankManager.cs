using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTankManager : MonoBehaviour
{
    public GameObject skyfallBtn;
    public GameObject gundamBtn;
    public GameObject ironBtn;

    private int tankSelect;

    private void Awake()
    {
        tankSelect = PlayerData.GetSelectTank();
    }
    private void Update()
    {
        tankSelect = PlayerData.GetSelectTank();

        if (tankSelect == 1)
        {
            skyfallBtn.SetActive(false);
            gundamBtn.SetActive(true);
            ironBtn.SetActive(true);
        }
        if (tankSelect == 2)
        {
            skyfallBtn.SetActive(true);
            gundamBtn.SetActive(false);
            ironBtn.SetActive(true);
        }
        if (tankSelect == 3)
        {
            skyfallBtn.SetActive(true);
            gundamBtn.SetActive(true);
            ironBtn.SetActive(false);
        }
    }
}
