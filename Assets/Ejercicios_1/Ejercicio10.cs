using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que cambie el nombre de todos los GameObjects de la escena en base a un atributo definido en este
    /// </summary>
    public class Ejercicio10 : MonoBehaviour
    {
        //❕ public string nombreNuevo = "NuevoNombre";
        void Start()
        {
            GameObject[] gameObjects = GameObject.FindObjectsOfType<GameObject>();
            string nombreNuevo = "NuevoNombre";

            for (int i = 0; i < gameObjects.Length; i++)
            {
                //❕ Esto no debería comprobarse por cada iteración, además FindObjectsOfType no devuelve null
                //❕ No se si estabas tratando de comprobar cada elemento (gameObjects[i] != null), eso tendría más sentido
                if (gameObjects != null) 
                {
                    gameObjects[i].name = nombreNuevo;
                }
            }
        }
    }
}