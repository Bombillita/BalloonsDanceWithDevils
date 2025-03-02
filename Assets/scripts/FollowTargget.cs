using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;  // El jugador u objeto al que la cámara seguirá
    public float followSpeed = 5f;  // Velocidad con la que la cámara se mueve
    public Vector3 offset;  // Desplazamiento respecto al objetivo (jugador)

    // Update is called once per frame
    void Update()
    {
        // Calculamos la posición deseada (posición del objetivo + offset)
        Vector3 targetPosition = target.position + offset;

        // Usamos Lerp para mover suavemente la cámara a la posición deseada
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
    }
}
