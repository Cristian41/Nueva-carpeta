using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    GameObject otro;
    string mensaje;
    float distancia;
    bool activo = true;
    int estado;
    Vector3 destino;
    public enum Estados
    {
        idle, moving
    }
    Estados zombi;
    public enum cuerpo
    {
        sesos, corazon, estomago, intestinos, cuello
    }
    cuerpo partes;
    public struct DatosZombie
    {
        public Color color;
        public cuerpo partes;

    }
    public void Start()
    {
        otro = gameObject;
        int escoge_color = UnityEngine.Random.Range(0, 3);
        if (escoge_color == 0)
        {
            otro.GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (escoge_color == 1)
        {
            otro.GetComponent<Renderer>().material.color = Color.green;
        }
        if (escoge_color == 2)
        {
            otro.GetComponent<Renderer>().material.color = Color.magenta;
        }
        otro.transform.position = new Vector3(UnityEngine.Random.Range(-15, 25), 0.4f, UnityEngine.Random.Range(-25, 26));
        otro.name = "Zombie";
        otro.AddComponent<Rigidbody>();
        if (activo)
        {
            StartCoroutine(estados_Z());
        }
        else if (activo == false)
        {
            StopCoroutine(estados_Z());
        }
    }
    public DatosZombie ObtenerZombieInfo()
    {
        DatosZombie dato = new DatosZombie();
        // Datos datos = new Datos();
        int parte = UnityEngine.Random.Range(0, 4);
        if (parte == 0)
        {
            dato.partes = cuerpo.corazon;
            mensaje = "Warrrrr soy un zombie y quiero comer " + dato.partes;
        }
        if (parte == 1)
        {
            dato.partes = cuerpo.cuello;
            mensaje = "Warrrrrr soy un Zombie y quiero comer " + dato.partes;
        }
        if (parte == 2)
        {
            dato.partes = cuerpo.estomago;
            mensaje = "Warrrrr soy un zombie y quiero comer " + dato.partes;
        }
        if (parte == 3)
        {
            dato.partes = cuerpo.intestinos;
            mensaje = "Warrrrr soy un zombie y quiero comer " + dato.partes;
        }
        if (parte == 4)
        {
            dato.partes = cuerpo.sesos;
            mensaje = "Warrrrr soy un zombie y quiero comer" + dato.partes;
        }
        return dato;
    }
    void Update()
    {
        if (zombi == Estados.idle)
        {
            
        }
        if (zombi == Estados.moving)
        {
            transform.Translate(destino * Time.deltaTime * 0.3f);
        }
    }
    public IEnumerator estados_Z()
    {
        zombi = (Estados)UnityEngine.Random.Range(0, 2);
        if (zombi == Estados.moving)
        {
            destino = new Vector3(UnityEngine.Random.Range(-15, 15), 0f, UnityEngine.Random.Range(-15, 15));
            yield return null;
        }
        yield return new WaitForSeconds(5f);
        yield return estados_Z();
    }
}
