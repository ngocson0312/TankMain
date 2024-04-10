using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyIron : MonoBehaviour
{
    private int cost = 900;
    private int coin;
    private int iron;

    public GameObject daMua;
    public GameObject canhBao;

    public GameObject buyBtn;
    public GameObject tryBtn;

    private void Awake()
    {
        coin = PlayerData.GetCoin();
    }
    public void BuyIronElephant()
    {
        if (coin < cost)
        {
            canhBao.SetActive(true);
        }
        else
        {
            daMua.SetActive(true);
            PlayerData.SetCoin(coin - cost);
            PlayerData.SetIron(1);
        }
    }
    private void Update()
    {
        iron = PlayerData.GetIron();
        if (iron == 1)
        {
            buyBtn.SetActive(false);
            tryBtn.SetActive(false);
        }
    }
}
