using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    public DoorControllerKey doorToOpen;
    public bool _isCollected = false;
    public DialogueScripttwo dscajas;
    public DialogueScripttwo dspuerta;
    public interactibleObj interc;

private void Update()
{
    if (_isCollected == true && Input.GetKeyDown(KeyCode.E))
        {
            doorToOpen.hasKey = true;

            if (dscajas.dialoguefinished == true)
            {
                dscajas.enabled = false;
                dspuerta.enabled = false;
                interc.caninteract = false;
            }
         
        }

}
 private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player") == true && _isCollected == false)
        {
            _isCollected = true;                 

        }
        else
        {
            _isCollected = false;
        }
    }
}
