using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // Start is called before the first frame update

    //Realizá un programa donde se cree una variable entera num1, que inicialmente valdrá 0. Luego incrementá su valor en 2 y mstrarlo por pantalla. Después mostrá el resultado de multiplicarlo por sí mismo.

    void Start()
    {
        int num1 = 0;
        Debug.Log(num1 += 2);
        Debug.Log(num1 * num1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
