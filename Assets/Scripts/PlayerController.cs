using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        //embarrassing playing controller script (forgot all the physics stuff.. and didn't had time to revisit last semester's nots)

        //variables for movements
        float horizontal = 0f;
        float vertical = 0f;

        //input detection
        if (Input.GetKey(KeyCode.W))
        {
            vertical += 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            horizontal -= 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vertical -= 1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            horizontal += 1f;
        }

        //deciding direction
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        //moving obj using transform, direction, speed
        transform.position += direction * speed * Time.deltaTime;
    }
}
