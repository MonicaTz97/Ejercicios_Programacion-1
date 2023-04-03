using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ejercicios_1;

public class Ejercicio06 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject sphere01Ejercicio06 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere01Ejercicio06.name = "Sphere01Ejercicio06";
        sphere01Ejercicio06.transform.position = new Vector3(0f, 0f, 0f);

        GameObject sphere02Ejercicio06 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere02Ejercicio06.name = "Sphere02Ejercicio06";
        sphere02Ejercicio06.transform.position = new Vector3(100f, 0f, 0f);
    }

}
