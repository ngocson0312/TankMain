using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Try : MonoBehaviour
{
    [SerializeField]
    private int tankTry = 1;

    public void TryTank()
    {
        PlayerData.SetTryTank(tankTry);
        SceneManager.LoadScene("Try1");
    }
}
