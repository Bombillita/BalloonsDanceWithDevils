using UnityEngine;

public class EffectsMeca : MonoBehaviour
{
    
    public GameObject linterna; 
    private bool lighton = false; 
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
