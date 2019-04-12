using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    GameObject enemigo;
    GameObject heroe;
    void Start()
    {
        heroe = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        heroe.AddComponent<Heroe>();
        for (int i = 0; i < 11; i++)
        {
            int escoge = UnityEngine.Random.Range(0, 2);
            
            if (escoge == 0)
            {
                enemigo = GameObject.CreatePrimitive(PrimitiveType.Cube);
                enemigo.AddComponent<Zombie>();
            }

            if (escoge == 1)
            {
                enemigo = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                enemigo.AddComponent<Aldeano>();
            }
        }
    }
}
   

   