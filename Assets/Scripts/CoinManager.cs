using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinManager : MonoBehaviour
{
    private int coin = 0;
    private int playerCoin;
    private int playerNewCoin;
    public Text coinText;
    public Text winCoin;
    public Text loseCoin;

    private void Awake()
    {
        playerCoin = PlayerData.GetCoin();
    }
    public int Coin
    {
        get { return coin; }
        set
        {
            coin = value;
            coinText.text = coin.ToString();
            winCoin.text = coin.ToString();
            loseCoin.text = (coin * 0.5).ToString();
        }
    }
    public void GetCoin( int getCoin)
    {
        Coin += getCoin;
    }
    public void GetCoinLose()
    {
        playerNewCoin = playerCoin + coin * 1/2;
        PlayerData.SetCoin(playerNewCoin);
    }
    public void GetCoinWin()
    {
        playerNewCoin = playerCoin + coin;
        PlayerData.SetCoin(playerNewCoin);
    }
}