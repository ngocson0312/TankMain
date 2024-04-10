using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(ObjectPool))]
public class SpawnDamageText : MonoBehaviour
{
    public GameObject damageText;

    private ObjectPool textPool;
    [SerializeField]
    private int bulletPoolCount = 10;
    public Transform pos;
    

    private void Awake()
    {
        textPool = GetComponent<ObjectPool>();
    }
    private void Start()
    {
        textPool.Initialize(damageText, bulletPoolCount);
    }
    public void Spawn(string damageText)
    {
        var text = textPool.CreateObject();
        text.transform.position = pos.position;
        text.transform.localRotation = pos.rotation;
        text.GetComponentInChildren<TMP_Text>().text = damageText;
    }
}
