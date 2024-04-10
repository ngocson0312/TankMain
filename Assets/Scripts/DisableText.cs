using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableText : MonoBehaviour
{
    [SerializeField]
    private float timeToDisable = 1f;

    private void Update()
    {
        StartCoroutine(DelayDisable());
    }

    void DisableHelper()
    {
        gameObject.SetActive(false);
    }

    IEnumerator DelayDisable()
    {
        yield return new WaitForSeconds(timeToDisable);
        DisableHelper();
    }
}
