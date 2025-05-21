using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderActivator : MonoBehaviour
{
    public Collider collidertrigger;
    public Collider colliderpro;
    public Diaryy diario;
    public DialogueScript ds;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && diario.diary == true)
        {

            colliderpro.enabled = true;
            ds.enabled = true;

        }
        else
        {
            colliderpro.enabled = false;
            ds.enabled = false;
        }

    }
}
