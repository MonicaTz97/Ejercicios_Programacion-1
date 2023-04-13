using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere 12 esferas cada una el doble de grande que la anterior
    /// </summary>
    public class Ejercicio09 : MonoBehaviour
    {
        void Start()
        {
            float x = 1f;

            for (int i = 0; i < 12; i++)
            {

                GameObject sphere01Ejercicio09 = GameObject.CreatePrimitive(PrimitiveType.Sphere);

                sphere01Ejercicio09.transform.position = new Vector3(i * 2f, 0f, 0f);

                sphere01Ejercicio09.transform.localScale = new Vector3(x, x, x);
                //❕ sphere01Ejercicio09.transform.localScale = Vector3.one * x;
                x *= 2;
            }

            //❕ Ejercicio08.CrearFiguras(PrimitiveType.Sphere, 12);
        }
    }
}