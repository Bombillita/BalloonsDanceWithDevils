using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diaryy : MonoBehaviour
{
    public bool diary = false;
    public GameObject obj;
    public GameObject dialogopadre;
    public Collider col;
 

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            diary = true;
            dialogopadre.SetActive(true);
            obj.SetActive(false);
            col.enabled = false;
        }
    }
}
