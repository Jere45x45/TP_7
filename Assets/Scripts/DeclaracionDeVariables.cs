using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    public int numeroInt = 1;
    public float numeroFloat = 2.1f;
    public string cadenaDeTexto = "DeclaracionDeVariable";
    public bool booleano = true;

    // Start is called before the first frame update
    void Start()
    {
     Debug.Log(numeroInt);
     Debug.Log(numeroFloat);
     Debug.Log(cadenaDeTexto);
     Debug.Log(booleano);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
