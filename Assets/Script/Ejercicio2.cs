﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    // Start is called before the first frame update

    //Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5, respectivamente, realice la operación correspondiente y muestre el resultado en pantalla:
    //a.Suma
    //b.Producto

    void Start()
    {
        int num1 = 4;
        int num2 = 5;

        Debug.Log("Suma: " + (num1 + num2));
        Debug.Log("Producto: " + (num1 * num2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
