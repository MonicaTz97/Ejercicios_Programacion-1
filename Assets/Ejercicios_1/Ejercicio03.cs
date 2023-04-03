using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ejercicios_1;

public class Ejercicio03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.name = "CubeEjercicio03";
        cube.transform.localScale = transform.localScale * 2;
    }

}
