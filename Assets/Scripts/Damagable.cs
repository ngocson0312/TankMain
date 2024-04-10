using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Damagable : MonoBehaviour
{
    public int MaxHealth = 100;
    [SerializeField]
    private int health = 0;
    private SpawnDamageText spawnDamageText;
    public TMP_Text hpText;

    public int Health
    {
        get { return health; }
        set
        {
            health = value;
            OnHealthChange?.Invoke((float)Health / MaxHealth);
        }
    }

    public UnityEvent OnDead;
    public UnityEvent<float> OnHealthChange;
    public UnityEvent OnHit, OnHeal;

    private void Update()
    {
        if (hpText)
        hpText.text = Health.ToString();
    }

    private void Start()
    {
        if (health == 0)
            Health = MaxHealth;
        spawnDamageText = GetComponentInChildren<SpawnDamageText>();
    }

    internal void Hit(int damagePoints)
    {
        Health -= damagePoints;
        if (Health <= 0)
        {
            OnDead?.Invoke();
        }else
        {
            OnHit?.Invoke();
            spawnDamageText.Spawn("-" + damagePoints.ToString());
        }
    }
    public void Heal(int healthBoost)
    {
        Health += healthBoost;
        Health = Mathf.Clamp(Health, 0, MaxHealth);
        OnHeal?.Invoke();
    }
}
