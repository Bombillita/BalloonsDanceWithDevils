using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsPlayer : MonoBehaviour
{
    //refs
    public PlayerController tPC;
    public GameObject linterna;

    //raycast
    public Transform lanternpivot;
    public LayerMask obstacleLayer;
    public bool raycasthit = false;

    //bools efectos
    public bool chubasquero = false;
    public bool atrapasuenos = false;
    public bool tirachinas = false;
    public bool trajedepureza = false;

    //efecto linterna
    public bool lighton = false;
    public bool lantern = false;

    //efecto tijeras
    public bool scissors = false;

    //efecto skates
    public bool skates = false;

    private void Update()
    {
        //LINTERNA

        if (lantern == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                ToggleLantern();
            }
        }

        if (lighton == true)
        {
            Vector3 dir = transform.position - lanternpivot.position;

            if (Physics.Raycast(lanternpivot.position, dir, out RaycastHit hit, dir.magnitude, obstacleLayer))
            {
                raycasthit = true;
            }
            else
            {
                raycasthit = false;
            }

            Debug.DrawRay(lanternpivot.position, dir, Color.yellow);

        }

        if (skates == true)
        {
            tPC.moveSpeed = 8;
        }
        else
        {
            tPC.moveSpeed = 4.2f;
        }

    }

    //desactivar los demas bools
    public void ActivateEffect(string effectName)
    {
        chubasquero = false;
        atrapasuenos = false;
        tirachinas = false;
        trajedepureza = false;
        skates = false;
        lantern = false;
        scissors = false;

        switch (effectName)
        {
            case "chubasquero":
                chubasquero = true;
                break;
            case "atrapasuenos":
                atrapasuenos = true;
                break;
            case "tirachinas":
                tirachinas = true;
                break;
            case "trajedepureza":
                trajedepureza = true;
                break;
            case "skates":
                skates = true;
                break;
            case "lantern":
                lantern = true;
                break;
            case "scissors":
                scissors = true;
                break;

        }
    }

     public void ToggleLantern()
    {
        if (lighton == false)
        {
            linterna.SetActive(true); 
            lighton = true;  
        }
        else
        {
            linterna.SetActive(false); 
            lighton = false;  
        }
    }
}