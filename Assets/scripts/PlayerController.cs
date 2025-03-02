using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 200f;
    private Vector3 input;
    private Rigidbody _rb;
    public Transform cameraTransform;

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

        // Calcular la direcci�n de movimiento con respecto a la c�mara
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        // Ignorar el componente Y para mantener el movimiento en el plano horizontal
        forward.y = 0;
        right.y = 0;

        input = (forward * _vertical + right * _horizontal).normalized;
        //Guardaremos el input para usarlo en el FixedUpdate

        //para que s mueva en la direccion conrrenta respecto a donde mira , hay qu trasnformar el input que sea en el espacio local y no es espacio global


        if (input.magnitude > 0)
        {


            // Rotar suavemente hacia la direcci�n de movimiento
            Quaternion targetRotation = Quaternion.LookRotation(input);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }


    }
    // Update is called once per frame
    void FixedUpdate()
    {// hay que normalizar el input para que no se mueva mas rapido en diagonal
        Vector3 _velocity = input.normalized * moveSpeed;
        _velocity.y = _rb.velocity.y;
        _rb.velocity = _velocity;
    }

}