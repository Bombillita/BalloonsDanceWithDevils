using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deactivateinfo : MonoBehaviour
{
    public GameObject ifno;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ifno.SetActive(false);
        }
    }


}
