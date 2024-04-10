using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    [SerializeField]
    private int level;

    public void RePlayLevel()
    {
        SceneManager.LoadScene(level);
        Time.timeScale = 1f;
    }

}
