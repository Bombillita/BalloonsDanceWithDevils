using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thirdpersoncontroller : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 200f;
    private Vector3 input;
    private Rigidbody _rb;


    // Start is called before the first frame update
    void Start()
    {
        //Para buscar y asignar el Rigidbody
        _rb = GetComponent<Rigidbody>();

        //buscamos la camara como objeto hijo
        //cam = GetComponentInChildren<Camera>();
    }
    void Update()
    {
        float _horizontal = Input.GetAxisRaw("Horizontal");
        float _vertical = Input.GetAxisRaw("Vertical");
        //Guardaremos el input para usarlo en el FixedUpdate
        input = new Vector3(_horizontal, 0f, _vertical);
        //para que s mueva en la direccion conrrenta respecto a donde mira , hay qu trasnformar el input que sea en el espacio local y no es espacio global
        input = transform.TransformDirection(input);

        
    }
    // Update is called once per frame
    void FixedUpdate()
    {// hay que normalizar el input para que no se mueva mas rapido en diagonal
        Vector3 _velocity = input.normalized * moveSpeed;
        _velocity.y = _rb.velocity.y;
        _rb.velocity = _velocity;
    }

}
