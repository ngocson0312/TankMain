using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTransition : MonoBehaviour
{
    public void Active()
    {
        gameObject.SetActive(true);
    }
    public void Active1()
    {
        gameObject.SetActive(false);
    }
    public void InvokeActive()
    {
        Invoke("Active", 0);
        Invoke("Active1", 0.3f);
    }
}
