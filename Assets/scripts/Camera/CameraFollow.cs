using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Referencia al objeto del jugador
    public Vector3 offset; // Desplazamiento de la cámara respecto al jugador
    public float smoothSpeed = 0.125f; // Velocidad de suavizado

    void LateUpdate()
    {
        // Calcula la posición deseada de la cámara
        Vector3 desiredPosition = player.position + offset;
        // Suaviza la transición de la cámara
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        // Asigna la nueva posición a la cámara
        transform.position = smoothedPosition;

        // Opcional: hacer que la cámara mire al jugador
        transform.LookAt(player);
    }
}