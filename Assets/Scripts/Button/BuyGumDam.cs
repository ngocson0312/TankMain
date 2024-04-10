using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyGumDam : MonoBehaviour
{
    private int cost = 1200;
    private int coin;
    private int gumdam;

    public GameObject daMua;
    public GameObject canhBao;

    public GameObject buyBtn;
    public GameObject tryBtn;

    private void Awake()
    {
        coin = PlayerData.GetCoin();
    }
    public void BuyGundam()
    {
        if (coin < cost)
        {
            canhBao.SetActive(true);
        }
        else
        {
            daMua.SetActive(true);
            PlayerData.SetCoin(coin - cost);
            PlayerData.SetGunDam(1);
        }
    }
    private void Update()
    {
        gumdam = PlayerData.GetGunDam();
        if (gumdam == 1)
        {
            buyBtn.SetActive(false);
            tryBtn.SetActive(false);
        }
    }
}
