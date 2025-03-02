using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectScissors : MonoBehaviour
{
    public EffectsPlayer effect;
    public bool _isCollected = false;
    public bool canCollect = false;

    private void Update()
    {
        if (canCollect == true && Input.GetKeyDown(KeyCode.E))
        {
            _isCollected = true;
            effect.ActivateEffect("scissors");
            canCollect = false;
            gameObject.SetActive(false);
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

