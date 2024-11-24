using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    //camera.main.viewporttoray();
    //refs
    public Thirdpersoncontroller tPC;
    public GameObject linterna;

    //bools efectos
    public bool skates = false;
    public bool chubasquero = false;
    public bool scissors = false;
    public bool atrapasuenos = false;
    public bool tirachinas = false;
    public bool trajedepureza = false;
    public bool lantern = false;

    //efecto linterna
    public bool llight = false;


    private void Update()
    {
        if (lantern == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (llight == false)
                {
                    linterna.SetActive(true);
                    llight = true;
                }
                else
                {
                    linterna.SetActive(false);
                    llight = false;
                }
            }
        }
        



        /*f (Input.GetKeyDown(KeyCode.E))
       {
           UsingEffect();
       } */
    }

    /*private void UsingEffect()
     {
       if (skates == true)
         {
             Debug.Log("Hola");
             //tPC.moveSpeed = tPC.moveSpeed * 2f;
         }
     } */


}
