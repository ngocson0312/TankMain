using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoomCondition : MonoBehaviour
{
    List<GameObject> MonsterListInRoom = new List<GameObject>();
    public bool playerInThisRoom = false;
    public bool isClearRoom = false;
    public int playerInRoom = 0;
    public UnityEvent Start, Clear;
   
    void Update()
    {
        if (playerInThisRoom)
        {
            if (MonsterListInRoom.Count <= 0 && !isClearRoom)
            {
                isClearRoom = true;
              //  Debug.Log(" Clear ");
                Clear.Invoke();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerInRoom++;
            if (playerInRoom ==1 )
            {
                Start.Invoke();
            }
            playerInThisRoom = true;
           // Debug.Log("Player in room");
        }
        if (other.tag == "Enemy")
        {
            MonsterListInRoom.Add(other.transform.parent.gameObject);
          //  Debug.Log(" Add Enemy : " + other.transform.parent.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInThisRoom = false;
          //  Debug.Log("Player Exit!");
        }
        if (other.CompareTag("Enemy"))
        {
            MonsterListInRoom.Remove(other.transform.parent.gameObject); 
        }
    }
}
