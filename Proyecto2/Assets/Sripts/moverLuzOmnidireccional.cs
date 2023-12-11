using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLight : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Puedes cambiar la velocidad de movimiento aquí

    void Update()
    {
        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveDirection.z += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveDirection.z -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection.x += 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection.x -= 1;
        }

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
