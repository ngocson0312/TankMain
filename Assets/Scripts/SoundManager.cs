using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public GameObject soundOff;
    public GameObject soundOn;
    private int soundValue;

    private void Update()
    {
        soundValue = PlayerData.GetSound();
        if (soundValue == 0)
        {
            OffSound();
        }
        else if (soundValue == 1)
        {
            OnSound();
        }
    }
    public void OffSound()
    {
        AudioListener.volume = 0;
        soundOff.SetActive(false);
        soundOn.SetActive(true);
    }
    public void OnSound()
    {
        AudioListener.volume = 1;
        soundOff.SetActive(true);
        soundOn.SetActive(false);
    }
}
