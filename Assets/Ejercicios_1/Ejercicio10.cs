using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ejercicios_1;

public class Ejercicio10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] gameObjects = GameObject.FindObjectsOfType<GameObject>();
        string nombreNuevo = "NuevoNombre";

        for(int i = 0; i < gameObjects.Length; i++)
        {
            if(gameObjects != null)
            {
                gameObjects[i].name = nombreNuevo;
            }
        }
    }
}
