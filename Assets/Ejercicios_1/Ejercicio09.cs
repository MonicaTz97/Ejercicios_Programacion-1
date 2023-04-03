using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ejercicios_1;

public class Ejercicio09 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = 1f;

        for (int i = 0; i < 12; i++)
        {
            
            GameObject sphere01Ejercicio09 = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            sphere01Ejercicio09.transform.position = new Vector3(i * 2f, 0f, 0f);

            sphere01Ejercicio09.transform.localScale = new Vector3(x, x, x);
            x *= 2;
        }
    }

}
