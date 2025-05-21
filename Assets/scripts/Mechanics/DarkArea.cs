using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkArea : MonoBehaviour
{
   // public SpriteRenderer pRender;
    public Collider pCollider;
    public bool dark = true;
    public EffectsPlayer effect;
    public bool iluminado = false;
    public GameObject negro;

    private void Update()
    {
        if (effect.raycasthit == true && iluminado == false)
        {
            dark = false;
            iluminado = true;
        }
        
        if (effect.raycasthit == false)
        {
            dark = true;
        }

        if (dark == true)
        {
            pCollider.enabled = true;
        }

        if (dark == false)
        {
            pCollider.enabled = false;
        }

        if (dark == false && iluminado == true)
        {
            pCollider.enabled = false;
            negro.SetActive(false);
        }

    }
}
