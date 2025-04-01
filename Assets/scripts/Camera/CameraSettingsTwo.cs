using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSettingsTwo : MonoBehaviour
{
    public Transform player;
    public LayerMask lMask;
    private Renderer objDes;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = transform.position - player.position;
        if (Physics.Raycast(player.position, dir, out RaycastHit hit, dir.magnitude, lMask))
        {
            if(objDes == null)
            {
                objDes = hit.collider.GetComponent<Renderer>();
                objDes.enabled = false;
            }

        }
        else
        {
            if (objDes != null)
            {
                objDes.enabled = true;
                objDes = null;
            }
        }

        Debug.DrawRay(player.position, dir, Color.yellow);
    }
}
