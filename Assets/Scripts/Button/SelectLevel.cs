using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    [SerializeField]
	private int level;

    public void PlayLevel()
    {
        SceneManager.LoadScene(level);
    }
   
}
