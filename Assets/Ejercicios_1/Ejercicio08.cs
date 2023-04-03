using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ejercicios_1;

public class Ejercicio08 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube01Ejercicio08 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube01Ejercicio08.name = "Cube01Ejercicio08";

        GameObject cube02Ejercicio08 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube02Ejercicio08.name = "Cube01Ejercicio08";
        cube02Ejercicio08.transform.localScale = cube01Ejercicio08.transform.localScale * 2;
        cube02Ejercicio08.transform.position = new Vector3(5f, 0f, 0f);

        GameObject cube03Ejercicio08 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube03Ejercicio08.name = "Cube01Ejercicio08";
        cube03Ejercicio08.transform.localScale = cube02Ejercicio08.transform.localScale * 2;
        cube03Ejercicio08.transform.position = new Vector3(10f, 0f, 0f);
    }
}
