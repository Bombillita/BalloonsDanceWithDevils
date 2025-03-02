using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Referencia al objeto del jugador
    public Vector3 offset; // Desplazamiento de la c�mara respecto al jugador
    public float smoothSpeed = 0.125f; // Velocidad de suavizado

    void LateUpdate()
    {
        // Calcula la posici�n deseada de la c�mara
        Vector3 desiredPosition = player.position + offset;
        // Suaviza la transici�n de la c�mara
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        // Asigna la nueva posici�n a la c�mara
        transform.position = smoothedPosition;

        // Opcional: hacer que la c�mara mire al jugador
        transform.LookAt(player);
    }
}