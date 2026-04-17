using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombre = "Pepe";
    public int edad = 44;
    public float estatura = 1.8f;
    public bool esONoDonante = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombre + ", tengo " + edad + ", mido " + estatura + " metros y es " + esONoDonante + " que soy donante de órganos.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
