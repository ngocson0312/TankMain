using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NextRoom : MonoBehaviour
{
    public Transform nextRoomPos;
    private Camera mainCamera;
    public UnityEvent GoToNextRoom;
    private void Start()
    {
        mainCamera = Camera.main;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GoToNextRoom.Invoke();
            collision.transform.position = nextRoomPos.position;
            mainCamera.transform.position = new Vector3(nextRoomPos.position.x, 0, -10);
        }
    }
    public void Active()
    {
        gameObject.SetActive(true);
    }
    public void InvokeActive()
    {
        Invoke("Active",1);
    }
}
