using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiExpropriationField : MonoBehaviour
{
    private void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        // пускать мб звук или эффект
    }
}
