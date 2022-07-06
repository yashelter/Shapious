using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public float healthPoint = 10f;
    public float damage;
    public int verticles;

    private void Update()
    {
        
    }
    public void GetDamage(float damage)
    {
        healthPoint -= damage;
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
