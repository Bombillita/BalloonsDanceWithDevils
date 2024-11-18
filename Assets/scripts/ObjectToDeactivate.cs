using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToDeactivate : MonoBehaviour
{
    public bool canbeDeactivated = false;
    // public bool deactivated = false;

    /*void Update()
   {
        if (canbeDeactivated == true)
       {
           deactivated = true;
       } 

} */

private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true) 
        {
            return;
        }

        if (canbeDeactivated == true)
        {
            gameObject.SetActive(false);
        }
        else
        {
            //dialogo
        }
       
    }
}
