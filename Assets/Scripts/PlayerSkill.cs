using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerSkill : MonoBehaviour
{
    public int maxMana = 100;
    private int mana = 0;

    private const float DOUBLE_CLICK_TIME = 0.2f;
    private float lastClickTime;

    public UnityEvent<float> OnManaChange;
    public UnityEvent OnSkill;

    private void Update()
    {
      if (Input.GetMouseButtonDown(0))
        {
            float lastClick = Time.time - lastClickTime;

            if (lastClick <= DOUBLE_CLICK_TIME && Mana >= maxMana)
            {
                OnSkill.Invoke();
                Mana = 0;
            }
            lastClickTime = Time.time;
        }
    }
    public int Mana
    {
        get { return mana; }
        set
        {
            mana = value;
            OnManaChange?.Invoke((float)mana / maxMana);
        }
    }
    public void GetMana()
    {
        Mana += 25;
    }
    
}
