using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTank : MonoBehaviour
{
    public void Skyfall()
    {
        PlayerData.SetShopElement(1);
    }
    public void Gundam()
    {
        PlayerData.SetShopElement(2);
    }
    public void Iron()
    {
        PlayerData.SetShopElement(3);
    }
    public void Coming()
    {
        PlayerData.SetShopElement(4);
    }
}
