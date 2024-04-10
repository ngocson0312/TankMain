using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronSkill : MonoBehaviour
{
    public GameObject shield;

    public void Skill()
    {
        shield.SetActive(true);
        Invoke("DisableSkill", 5);
    }
    public void DisableSkill()
    {
        shield.SetActive(false);
    }
   
}
