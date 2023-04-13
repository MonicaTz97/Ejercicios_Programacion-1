using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere una esfera al inicio con un Rigidbody añadido
    /// </summary>
    public class Ejercicio04 : MonoBehaviour
    {
        void Start()
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.name = "SphereEjercicio04";
            Rigidbody rb = sphere.AddComponent<Rigidbody>();
        }
    }
}