using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSettings : MonoBehaviour
{
    public Transform player;
    public LayerMask obstacleLayer;
    private Renderer dobject;

    void Update()
    {
        Vector3 dir = transform.position - player.position;
        if (Physics.Raycast(player.position, dir, out RaycastHit hit, dir.magnitude, obstacleLayer))
        {
            if (dobject == null)
            {
                dobject = hit.collider.GetComponent<Renderer>();
                dobject.enabled = false;
            }
        }
        else
        {
            if (dobject != null)
            {
                dobject.enabled = true;
                dobject = null;
            }
        }

        Debug.DrawRay(player.position, dir, Color.yellow);
    }
}
