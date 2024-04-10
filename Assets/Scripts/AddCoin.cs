using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCoin : MonoBehaviour
{
    private CoinManager coin;
    [SerializeField]
    private int addCoin;
    void Start()
    {
        coin = FindObjectOfType<CoinManager>();
    }
    public void AddCoinOnDeath()
    {
        if (coin != null)
            coin.GetCoin(addCoin);
        else return;
    }
}
