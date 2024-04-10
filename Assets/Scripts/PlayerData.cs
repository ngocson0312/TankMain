using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerData
{
    public const string ALL_DATA = "all_data6";

    private static AllData allData;

    static PlayerData()
    {
        // Chuyển dl từ json qua all data
        allData = JsonUtility.FromJson<AllData>(PlayerPrefs.GetString(ALL_DATA));

        if (allData == null)
        {
            allData = new AllData
            {
                coin = 0,
                level = 1,
                sound = 1,
                selectTank = 1,
                shopElement = 1,
                gundamOwn = 0,
                ironOwn = 0,
                tryTank = 2,
            };
            SaveData();
        }
    }
    public static void SaveData()
    {
        // Chuyen du lieu tu alldata qua json
        var json = JsonUtility.ToJson(allData);
        PlayerPrefs.SetString(ALL_DATA, json);
    }
    public static int GetCoin()
    {
        return allData.coin;
    }
    public static void SetCoin (int coin)
    {
        allData.SetCoin(coin);
        SaveData();
    }
    public static int GetLevel()
    {
        return allData.level;
    }
    public static void SetLevel(int level)
    {
        allData.SetLevel(level);
        SaveData();
    }
    public static int GetSound()
    {
        return allData.sound;
    }
    public static void SetSound(int sound)
    {
        allData.SetSound(sound);
        SaveData();
    }
    public static int GetShopElement()
    {
        return allData.shopElement;
    }
    public static void SetShopElement(int shopElement)
    {
        allData.SetShopElement(shopElement);
        SaveData();
    }
    public static int GetSelectTank()
    {
        return allData.selectTank;
    }
    public static void SetSelectTank(int selectTank)
    {
        allData.SetSlectTank(selectTank);
        SaveData();
    }

    public static int GetTryTank()
    {
        return allData.tryTank;
    }
    public static void SetTryTank(int tryTank)
    {
        allData.SetTryTank(tryTank);
        SaveData();
    }

    public static int GetGunDam()
    {
        return allData.gundamOwn;
    }
    public static void SetGunDam(int gundam)
    {
        allData.SetGunDam(gundam);
        SaveData();
    }

    public static int GetIron()
    {
        return allData.ironOwn;
    }
    public static void SetIron(int iron)
    {
        allData.SetIron(iron);
        SaveData();
    }
    public class AllData
    {
        public int coin;
        public int level;
        public int sound;
        public int selectTank;
        public int shopElement;
        public int gundamOwn;
        public int ironOwn;
        public int tryTank;

        public void SetCoin(int _coin)
        {
            this.coin = _coin;
        }

        public void SetLevel(int _level)
        {
            this.level = _level;
        }

        public void SetSound(int sound)
        {
            this.sound = sound;
        }
        public void SetShopElement(int shopElement)
        {
            this.shopElement = shopElement;
        }
        public void SetSlectTank(int selectTank)
        {
            this.selectTank = selectTank;
        }
        public void SetTryTank(int tryTank)
        {
            this.tryTank = tryTank;
        }
        public void SetGunDam(int gumdam)
        {
            this.gundamOwn = gumdam;
        }
        public void SetIron(int iron)
        {
            this.ironOwn = iron;
        }
    }
}
