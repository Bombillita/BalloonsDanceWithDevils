using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeItem : MonoBehaviour
{
    public Item colorType;
    private Rigidbody rb;
    private Collider col;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
    }
    
   public void Pick (Transform _player)
    {
        rb.isKinematic = true;
        transform.SetParent(_player);
        transform.localPosition = Vector3.forward;
        //Desactivar el collider para queno choque con el jugador
        col.enabled = false;

    }
    public void Drop ()
    {
        rb.isKinematic = false;
        //desenparentarse del jugador
        transform.SetParent(null);
        //Volver a activar el collider
        col.enabled = true;
    }
  

}
