using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere tres cubos cada uno el doble de grande que el anterior
    /// </summary>
    public class Ejercicio08 : MonoBehaviour
    {
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

            //❕ CrearFiguras(PrimitiveType.Cube, 3);
        }

        //❕
        public static void CrearFiguras(PrimitiveType figura, int cantidad, float separacion = 0f)
        {
            float x = -0.5f; //Para que el primero se dibuje en (0, 0, 0)
            for (int i = 0; i < cantidad; i++)
            {
                GameObject cubo = GameObject.CreatePrimitive(figura);
                float size = Mathf.Pow(2f, i); //1, 2, 4, 8, 16
                cubo.transform.localScale = Vector3.one * size;
                x += size/2f; //Empujamos el punto de creación la mitad del tamaño que tiene
                cubo.transform.position = new Vector3(x, 0f, 0f);
                x += size/2f; //Empujamos la otra mitad para retomar desde ahí en el próximo
                x += separacion; //Añadimos la separación que queremos entre cubos
            }
        }
    }
}