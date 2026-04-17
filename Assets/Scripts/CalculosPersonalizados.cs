using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculosPersonalizados : MonoBehaviour
{
    public float num1 = 4;
    public float num2 = 2;
    public float resultado; 
    // Start is called before the first frame update
    void Start()
    {
        resultado = num1 + num2;
        Debug.Log("El resultado de sumar " + num1 + " y " + num2 + " es: " + resultado);
        resultado = num1 - num2;
        Debug.Log("El resultado de restar " + num1 + " y " + num2 + " es: " + resultado);
        resultado = num1 * num2;
        Debug.Log("El resultado de multiplicar " + num1 + " y " + num2 + " es: " + resultado);
        resultado = num1 / num2;
        Debug.Log("El resultado de dividir " + num1 + " y " + num2 + " es: " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
