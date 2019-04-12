using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aldeano : Character
{
    string mensage;
    int edad;
    string nombrec;
    public enum Nombre
    {
        María_Carmen, María, Carmen, Josefa, Ana_Maria, Isable, Maria_Dolores, Laura, Maria_Teresa, Antonia, Jose, Manuel, Francisco
          , David, Juan, Jose_Antonio, Javier, Jose_Luis, Daniel, Camila
    }
    public struct Datos
    {
        public int edad;
        public string nombre;
    }
    GameObject ojo;
    public void Start()
    {
        ojo = gameObject;
        ojo.name = "Ciudadano";
        nombrec = ((Nombre)Random.Range(0, 20)).ToString();
        edad = Random.Range(15, 100);
        ojo.transform.position = new Vector3(Random.Range(-25, 20), 0.4f, Random.Range(-20, 20));
        ojo.AddComponent<Rigidbody>();
    }
    public Datos ObtenerCiudadanoInf()
    {
        Datos dato = new Datos();
        dato.edad = edad;
        dato.nombre = nombrec;
        return dato;
    }
}


