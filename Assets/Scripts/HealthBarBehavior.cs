using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehavior : MonoBehaviour
{
    public Slider slider;
   
    public Vector3 offset;
    public Image fill;
    public Gradient gradient;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        SetHealth(health);
        slider.gameObject.SetActive(false);
    }

    public void SetHealth(int health)
    {
        slider.gameObject.SetActive(true);
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
    
    void FixedUpdate()
    {
        slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + offset);
    }

}
