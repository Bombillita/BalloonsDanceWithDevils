using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkArea : MonoBehaviour
{
    //public Renderer pRender;
    public Collider pCollider;
    public bool dark = true;
    public EffectsPlayer effect;

    private void Update()
    {
        if (effect.raycasthit == true)
        {
            dark = false;
        }
        else
        {
            dark = true;
        }

        if (dark == true)
        {
            //pRender.enabled = true;
            pCollider.enabled = true;
        }
        else
        {
            //pRender.enabled = false;
            pCollider.enabled = false;
        }
    }
}
