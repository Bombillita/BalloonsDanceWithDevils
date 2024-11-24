using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectLantern : MonoBehaviour
{
    public DoorController doorToOpen;
    public Effects effect;
    public bool _isCollected = false;
    public bool canCollect = false;

    private void Update()
    {
        if (canCollect == true && Input.GetKeyDown(KeyCode.E))
        {
            _isCollected = true;
            doorToOpen.hasKey = true;
            effect.lantern = true;
            canCollect = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true && _isCollected == false)
        {
            canCollect = true;
        }
        else
        {
            canCollect = false;
        }
    }
}

