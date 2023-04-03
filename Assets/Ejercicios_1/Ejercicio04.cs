using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ejercicios_1;

public class Ejercicio04 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.name = "SphereEjercicio04";
        Rigidbody rb = sphere.AddComponent<Rigidbody>();
    }
}
