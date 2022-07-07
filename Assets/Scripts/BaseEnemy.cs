using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public HealthBarBehavior healthBar;
    public int healthPoint = 10;
    public float damage;
    public int verticles;

    protected void Start()
    {
        healthBar.SetMaxHealth(healthPoint);

    }
    protected void Update()
    {
        
    }
    public void GetDamage(int damage)
    {
        healthPoint -= damage;
        healthBar.SetHealth((int)healthPoint);
        Debug.Log(healthPoint);
        if (healthPoint <= 0)
        {
            Die();
        }
    }
    protected void Die()
    {
        Destroy(gameObject);
    }

}
