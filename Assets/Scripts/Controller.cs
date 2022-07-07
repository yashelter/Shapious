using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Transform position;
    private float min, max;
    private float size = 1f;
    private int damage = 1;
    // Start is called before the first frame update
    private void Start()
    {
        position = GetComponent<Transform>();
        min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)).x;
        max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1)).x;

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Rotate(3f);
            if (max > transform.position.x + size / 2 + 0.15f * size)
            {
                Move(2f);
            }
        }
        else if (Input.GetKey(KeyCode.Mouse1))
        {
            Rotate(-3f);
            if (min < transform.position.x - size / 2 - 0.15f * size)
            {
                Move(-2f);
            }
        }
        else
        {
            position.Translate(new Vector2(0, 0));
        }
    }
    private void Rotate(float power)
    {
        power = 100f * power;
        position.Rotate(0, 0, Time.deltaTime * power, Space.World);
    }
    private void Move(float speed)
    {
        speed = speed * 0.001f;
        position.Translate(new Vector2(speed, 0), Space.World);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<BaseEnemy>().GetDamage(damage); // переделать, кривое
        }
    }

}
