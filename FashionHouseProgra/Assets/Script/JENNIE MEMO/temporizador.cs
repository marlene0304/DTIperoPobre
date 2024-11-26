using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Timer : MonoBehaviour
{

    public TMP_Text numero;
    public float contador;

    //string = es un arreglo de char
    // string = texto

    // Start is called before the first frame update
    void Start()
    {
        contador = 60;
        print("Esto es un string");
        numero.text = contador.ToString();
    }
    // Update is called once per frame
    void Update()
    {

        numero.text = contador.ToString("F1");

        if (contador >= 0)
        {
            //Contador
            //Time.deltatime agarra el tiempo de la pc
            contador = contador - Time.deltaTime;
        }
        else
        {
            //Que pasa si se acabo el contador
            contador = 60;
        }
       


        
    }
} 