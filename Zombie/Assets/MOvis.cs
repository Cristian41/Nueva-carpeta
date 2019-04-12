using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOvis : MonoBehaviour
{

    Zombie z;
    Vector3 movimiento;
    Rigidbody rb;
    float velocidad = 7.8f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float posH = Input.GetAxisRaw("Horizontal");
        float PosV = Input.GetAxisRaw("Vertical");
        Mov(posH, PosV);
        Rotar();
    }

    public void Mov(float ph, float pv)
    {
        movimiento.Set(ph, 0, pv);
        movimiento = movimiento.normalized * Time.deltaTime * velocidad;
        rb.MovePosition(transform.position + movimiento);
    }

    public void Rotar()
    {

        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(0, 0.5f, 0);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.Rotate(0, -0.5f, 0);
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Zombie>())
        {
            Zombie z = collision.collider.GetComponent<Zombie>();
            Debug.Log(" warrrrrrrr Soy un zombie y me gusta " + z.ObtenerZombieInfo().partes);
        }

        if (collision.collider.GetComponent<Aldeano>())
        {
            Aldeano c = collision.collider.GetComponent<Aldeano>();
            Debug.Log("Mi Nombre es :" + c.ObtenerCiudadanoInf().nombre + " y tengo " + c.ObtenerCiudadanoInf().edad + " años");
        }
    }
}
