using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectLantern : MonoBehaviour
{
    public DoorController doorToOpen;
    public EffectsPlayer effect;
    public bool _isCollected = false;
    public bool canCollect = false;
    public GameObject linternasprite;
    public DialogueScripttwo ds;

    private void Update()
    {
        if (canCollect == true && Input.GetKeyDown(KeyCode.E))
        {
            _isCollected = true;
            doorToOpen.hasKey = true;
            effect.ActivateEffect("lantern");
            canCollect = false;
            linternasprite.SetActive(false);

        }

        if (_isCollected == true && ds.dialoguefinished == true)
        {
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

