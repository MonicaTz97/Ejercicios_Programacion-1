using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ejercicios_1;

public class Ejercicio07 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject sphere01Ejercicio07 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere01Ejercicio07.name = "Sphere01Ejercicio07";
        sphere01Ejercicio07.transform.position = new Vector3(4f, 0f, 0f);

        GameObject sphere02Ejercicio07 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere02Ejercicio07.name = "Sphere02Ejercicio07";
        sphere02Ejercicio07.transform.position = new Vector3(104f, 0f, 0f);

        GameObject sphere03Ejercicio07 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere03Ejercicio07.name = "Sphere03Ejercicio07";
        sphere03Ejercicio07.transform.position = new Vector3(204f, 0f, 0f);

    }

}
