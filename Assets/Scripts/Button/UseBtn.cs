using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseBtn : MonoBehaviour
{
    [SerializeField]
    private int selectTank = 1;

    public void SelectTank()
    {
        PlayerData.SetSelectTank(selectTank);
    }
}
