using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkArea : MonoBehaviour
{
    Transform playerTransform;
    public float requiredDistance;

   public SpriteRenderer pRender;
    public Collider pCollider;
    public bool dark = true;
    public bool alreadyActive;
    public EffectsPlayer effect;
    public GameObject negro;
    public float timedark=5f;
    private float timedarkcounter;

    private void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        //if (effect.raycasthit == true && dark == true)
        //{
        //    dark = false;
        //    timedarkcounter = timedark;
        //}

        if ((playerTransform.position - transform.position).magnitude <= requiredDistance && effect.lighton == true)
        {
            dark = false;
            timedarkcounter = timedark;
        }

        if (dark == true)
        {
            pCollider.enabled = true;
        }

        if (dark == false)
        {
            if (!alreadyActive)
            {
                pCollider.enabled = false;
            }
            pRender.enabled = false;
        }
        if (timedarkcounter > 0 && effect.raycasthit == false)
        {
            timedarkcounter -= Time.deltaTime; 
            if (timedarkcounter <= 0)
            {
                dark = true;
                alreadyActive = true;
            }
        }

    }

    private void DarkEvent()
    {

    }
}
