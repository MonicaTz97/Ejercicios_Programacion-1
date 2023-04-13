using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere tres esferas al inicio separadas 100 metros
    /// </summary>
    public class Ejercicio07 : MonoBehaviour
    {
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

            //❕ CrearEsferas();
        }

        //❕
        void CrearEsferas()
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esfera.name = "Sphere" + string.Format("{0:00}", i+1) + "Ejercicio07";
                esfera.transform.position = Vector3.right * (i * 100f + 4f);
            }
        }
    }
}