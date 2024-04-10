using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Coin : MonoBehaviour
{
    public Text coinText;
    private int coin;

    private void Awake()
    {
        coin = PlayerData.GetCoin();
    }
    private void Update()
    {
        coinText.text = coin.ToString();
    }
}
