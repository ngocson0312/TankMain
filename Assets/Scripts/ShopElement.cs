using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopElement : MonoBehaviour
{
    private int shopElement;

    public GameObject skyfall;
    public GameObject gundam;
    public GameObject iron;
    public GameObject coming;

    private void Awake()
    {
        shopElement = PlayerData.GetShopElement();
    }
    private void Update()
    {
        shopElement = PlayerData.GetShopElement();
        if (shopElement == 1)
        {
            skyfall.SetActive(true);
        } else skyfall.SetActive(false);

        if (shopElement == 2)
        {
            gundam.SetActive(true);
        } else gundam.SetActive(false);

        if(shopElement == 3)
        {
            iron.SetActive(true);
        } else iron.SetActive(false);

        if (shopElement == 4)
        {
            coming.SetActive(true);
        } else coming.SetActive(false);
    }
}
