using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 200f;
    public float camXRot = 0f;
    ///Pivote de la camnara que tene que rotar en eje X
    public Transform cameraPivot;
    //Para guardar el input en Update y usarlo en FixedUpdate


    public Transform groundCheckerCenter;
    public Vector3 groundCheckerSize = Vector3.one;
    private Vector3 input;
    private Rigidbody _rb;
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        //Para buscar y asignar el Rigidbody
        _rb = GetComponent<Rigidbody>();
        //buscamos la camara como objeto hijo
        cam = GetComponentInChildren<Camera>();
    }
    void Update()
    {
        float _horizontal = Input.GetAxisRaw("Horizontal");
        float _vertical = Input.GetAxisRaw("Vertical");
        //Guardaremos el input para usarlo en el FixedUpdate
        input = new Vector3(_horizontal, 0f, _vertical);
        //para que s mueva en la direccion conrrenta respecto a donde mira , hay qu trasnformar el input que sea en el espacio local y no es espacio global
        input = transform.TransformDirection(input);

        //rotar
        //float _roteMouseX = Input.GetAxisRaw("Mouse X");
        //transform.Rotate(0, _roteMouseX * rotationSpeed * Time.deltaTime, 0); //si no hay deltatime giramos infinitamente 
        //HAy que ir acumulando el valor de la rotación en X de la camara
        //para que aumente o disminuya conforme movemos el raton arriba y abajo
        //camXRot -= Input.GetAxisRaw("Mouse Y") * rotationSpeed * Time.deltaTime;
        //Limitamos el valor de la rotacion X a -60 y a 60 grados
        //camXRot = Mathf.Clamp(camXRot, -60, 60);
        //Asignamos la rotación en X a los angulos del pivote de la camara
        //cameraPivot.transform.localEulerAngles = new Vector3(camXRot, 0, 0);
        //Physics.overlap
    }
    // Update is called once per frame
    void FixedUpdate()
    {// hay que normalizar el input para que no se mueva mas rapido en diagonal
        Vector3 _velocity = input.normalized * moveSpeed;
        _velocity.y = _rb.velocity.y;
        _rb.velocity = _velocity;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube(groundCheckerCenter.position, groundCheckerSize);
    }
}
