using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman : MonoBehaviour
{
    public float distance = 5.0f; // La distancia que se moverá la esfera
    public float speed = 7.0f; // La velocidad del movimiento

    // Start is called before the first frame update
    void Start()
    {
        // Inicia la corutina que controla el movimiento
        StartCoroutine(MoveBackAndForth());
    }

    IEnumerator MoveBackAndForth()
    {
        for (int i = 0; i < 6; i++) // Repite el movimiento 3 veces
        {
            // Mover de arriba a abajo
            yield return Move(Vector3.up, distance);
            yield return Move(Vector3.down, distance);

            // Mover de derecha a izquierda
            yield return Move(Vector3.right, distance);
            yield return Move(Vector3.left, distance);
        }
    }

    // Función para mover la esfera en una dirección por una cierta distancia
    IEnumerator Move(Vector3 direction, float distance)
    {
        float startMovement = 0;
        Vector3 startPosition = transform.position;
        Vector3 endPosition = startPosition + direction * distance;

        while (startMovement < 1)
        {
            startMovement += Time.deltaTime * speed;
            transform.position = Vector3.Lerp(startPosition, endPosition, startMovement);
            yield return null;
        }
    }
}
