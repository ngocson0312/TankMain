using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mana : MonoBehaviour
{
    private PlayerSkill player;
    void Update()
    {
         player = FindObjectOfType<PlayerSkill>();
    } 
    public void ManaOnDeath()
    {
        if (player != null)
            player.GetMana();
        else return;
    }
}
