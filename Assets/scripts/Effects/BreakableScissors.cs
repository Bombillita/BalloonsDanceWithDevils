using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BreakableScissors : MonoBehaviour
{
    private Effects eref;
    public bool cancut = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") == true && Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gameObject);
        }
    }
}
