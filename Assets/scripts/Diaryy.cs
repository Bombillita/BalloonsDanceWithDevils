using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diaryy : MonoBehaviour
{
    public bool diary = false;
    public GameObject obj;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            diary = true;
            obj.SetActive(false);
        }

    }
}
