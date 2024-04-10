using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject waring;
    public void Pause()
    {
        Time.timeScale = 0f;
        gameObject.SetActive(false);
        pauseMenu.SetActive(true);
    }
    public void Resum()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(true);
        pauseMenu.SetActive(false);
    }
    public void OffSound()
	{
        PlayerData.SetSound(0);
	}
    public void OnSound()
    {
        PlayerData.SetSound(1);
    }
    public void Replay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Map1");
        gameObject.SetActive(true);
    }
    public void Confirm()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void Reject()
    {
        waring.SetActive(false);
    }
    public void Home()
    {
        waring.SetActive(true);
    }
}
