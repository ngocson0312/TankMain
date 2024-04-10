using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tank : MonoBehaviour
{
    public void TankView()
    {
        SceneManager.LoadScene("Tank");
    }
}
