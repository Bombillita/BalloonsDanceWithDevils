using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour
{
    public DoorController doorToOpen;
    public bool _isCollected = false;

    private void Update()
    {
        if (_isCollected && Input.GetKeyDown(KeyCode.E))
        {

            Destroy(gameObject);

        }

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player") == true && _isCollected == false)
        {
            _isCollected = true;
            doorToOpen.hasKey = true;


        }
        else
        {
            _isCollected = false;
            doorToOpen.hasKey = false;
        }
    }
}