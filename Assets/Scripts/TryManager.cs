using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryManager : MonoBehaviour
{
    private int tryTank = 1;

    public void ResetTankTry()
    {
        PlayerData.SetTryTank(tryTank);
    }
}
