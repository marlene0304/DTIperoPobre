using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tematica : MonoBehaviour
{
    //Aqui se guardan todas las tematicas
    public string[] tematicas;
    //Selecciona un espacio del arreglo de tematicas[] 
    public int tematicaSeleccionada;
    //La UI de que tematica toco
    public TMP_Text tematicaUI;
    //La UI del puntaje
    public TMP_Text puntajeUI;
    //puntaje total que lleva
    public int puntaje;


    //Arreglos de ropa
    public Sprite[] pelo;
    public Sprite[] calzado;
    public Sprite[] pantalon;
    public Sprite[] camisa;
    public Sprite[] accesorio;

    //Numero de la actual prenda
    //No modificar
    public int numeroDePelo, numeroDeCalzado, numeroDePantalon, numeroDeCamisa, numeroDeAccesorio;

    //Aqui va los sprites de la UI
    public Image imagenPelo, imagenAccesorio, imagenCamisa, imagenPantalon, imagenCalzado;


    // Start is called before the first frame update
    void Start()
    {
        //Seleccionar al azar tematica
                                        //Esto va del 0 al 4
        tematicaSeleccionada = Random.Range(0,5);
        tematicaUI.text = tematicas[tematicaSeleccionada];

    }

    // Update is called once per frame
    void Update()
    {
        //Solo testeo
        /*ChangeColor(imagenPelo, numeroDePelo);
        ChangeColor(imagenAccesorio, numeroDeAccesorio);
        ChangeColor(imagenCamisa, numeroDeCamisa);
        ChangeColor(imagenPantalon, numeroDePantalon);
        ChangeColor(imagenCalzado, numeroDeCalzado);
        */
        imagenPelo.sprite = pelo[numeroDePelo];
        imagenAccesorio.sprite = accesorio[numeroDeAccesorio];
        imagenCamisa.sprite = camisa[numeroDeCamisa];
        imagenPantalon.sprite = pantalon[numeroDePantalon];
        imagenCalzado.sprite = calzado[numeroDeCalzado];

        if (numeroDeCalzado == 0 && tematicaSeleccionada == 0)
        {
            print("Este es el calzado de invierno y es tematica de invierno");
        }
        if(numeroDeCamisa == 0)
        {
            print("Este es el calzado de invierno");
        }

        

        
    }

    //Calcula el puntaje //test //test2
    public void Finish()
    {
        //Tematicas: 0-Invierno 1-Festival 2-Verano 3-Gala 4-Cyberpunk
        //Parte del cuerpo: 0-Cabeza 1-Camisa 2-Pantalon 3-Calzado 4-Accesorio
        PuntosPorPrenda(0, numeroDePelo, tematicaSeleccionada);
        PuntosPorPrenda(1, numeroDeCamisa, tematicaSeleccionada);
        PuntosPorPrenda(2, numeroDePantalon, tematicaSeleccionada);
        PuntosPorPrenda(3, numeroDeCalzado, tematicaSeleccionada);
        PuntosPorPrenda(4, numeroDeAccesorio, tematicaSeleccionada);
        //Lo que se muestra en UI
        puntajeUI.text = (PuntosPorPrenda(0, numeroDePelo, tematicaSeleccionada) + PuntosPorPrenda(1, numeroDeCamisa, tematicaSeleccionada) +
            PuntosPorPrenda(2, numeroDePantalon, tematicaSeleccionada) + PuntosPorPrenda(3, numeroDeCalzado, tematicaSeleccionada) +
            PuntosPorPrenda(4, numeroDeAccesorio, tematicaSeleccionada)).ToString();
        //Lo que lleva el jugador en total
        puntaje = puntaje + int.Parse(puntajeUI.text);

    }

    //NO TOCAR //Agregado valores por prenda en Invierno, Gala y Cyberpunk
    public int PuntosPorPrenda(int NumeroDeLaParteDeLaPrenda, int PrendaSeleccionada, int Tematica)
    {
        //Tematicas: 0-Invierno 1-Festival 2-Verano 3-Gala 4-Cyberpunk
        //Parte del cuerpo: 0-Cabeza 1-Camisa 2-Pantalon 3-Calzado 4-Accesorio

        switch(Tematica)
        {
            case 0:
                switch (NumeroDeLaParteDeLaPrenda)
                {
                    case 0:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 5;
                            case 1:
                                return 5;
                            case 2:
                                return 5;
                            case 3:
                                return 5;
                            case 4:
                                return 5;
                        }
                        break;
                    case 1:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 3;
                            case 1:
                                return 1;
                            case 2:
                                return 1;
                            case 3:
                                return 4;
                            case 4:
                                return 1;
                        }
                        break;
                    case 2:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 1;
                            case 1:
                                return 1;
                            case 2:
                                return 1;
                            case 3:
                                return 1;
                            case 4:
                                return 1;
                        }
                        break;
                    case 3:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 1;
                            case 1:
                                return 4;
                            case 2:
                                return 5;
                            case 3:
                                return 3;
                            case 4:
                                return 3;
                        }
                        break;
                    case 4:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 4;
                            case 1:
                                return 2;
                            case 2:
                                return 1;
                            case 3:
                                return 4;
                            case 4:
                                return 2;
                        }
                        break;
                }
                break;
            case 1:
                switch (NumeroDeLaParteDeLaPrenda)
                {
                    case 0:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 4;
                            case 1:
                                return 5;
                            case 2:
                                return 1;
                            case 3:
                                return 2;
                            case 4:
                                return 4;
                        }
                        break;
                    case 1:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 3;
                            case 1:
                                return 5;
                            case 2:
                                return 2;
                            case 3:
                                return 1;
                            case 4:
                                return 4;
                        }
                        break;
                    case 2:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 1;
                            case 1:
                                return 5;
                            case 2:
                                return 1;
                            case 3:
                                return 2;
                            case 4:
                                return 3;
                        }
                        break;
                    case 3:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 4;
                            case 1:
                                return 5;
                            case 2:
                                return 1;
                            case 3:
                                return 1;
                            case 4:
                                return 4;
                        }
                        break;
                    case 4:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 1;
                            case 1:
                                return 5;
                            case 2:
                                return 2;
                            case 3:
                                return 1;
                            case 4:
                                return 3;
                        }
                        break;
                }
                break;
            case 2:
                switch (NumeroDeLaParteDeLaPrenda)
                {
                    case 0:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 2;
                            case 1:
                                return 3;
                            case 2:
                                return 5;
                            case 3:
                                return 4;
                            case 4:
                                return 3;
                        }
                        break;
                    case 1:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 2;
                            case 1:
                                return 2;
                            case 2:
                                return 5;
                            case 3:
                                return 1;
                            case 4:
                                return 1;
                        }
                        break;
                    case 2:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 1;
                            case 1:
                                return 4;
                            case 2:
                                return 5;
                            case 3:
                                return 1;
                            case 4:
                                return 2;
                        }
                        break;
                    case 3:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 2;
                            case 1:
                                return 2;
                            case 2:
                                return 5;
                            case 3:
                                return 2;
                            case 4:
                                return 1;
                        }
                        break;
                    case 4:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 1;
                            case 1:
                                return 4;
                            case 2:
                                return 5;
                            case 3:
                                return 1;
                            case 4:
                                return 1;
                        }
                        break;
                }
                break;
            case 3:
                switch (NumeroDeLaParteDeLaPrenda)
                {
                    case 0:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 3;
                            case 1:
                                return 4;
                            case 2:
                                return 3;
                            case 3:
                                return 3;
                            case 4:
                                return 4;
                        }
                        break;
                    case 1:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 1;
                            case 1:
                                return 1;
                            case 2:
                                return 1;
                            case 3:
                                return 1;
                            case 4:
                                return 1;
                        }
                        break;
                    case 2:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 1;
                            case 1:
                                return 1;
                            case 2:
                                return 1;
                            case 3:
                                return 1;
                            case 4:
                                return 1;
                        }
                        break;
                    case 3:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 5;
                            case 1:
                                return 5;
                            case 2:
                                return 5;
                            case 3:
                                return 5;
                            case 4:
                                return 5;
                        }
                        break;
                    case 4:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 1;
                            case 1:
                                return 1;
                            case 2:
                                return 1;
                            case 3:
                                return 1;
                            case 4:
                                return 1;
                        }
                        break;
                }
                break;
            case 4:
                switch (NumeroDeLaParteDeLaPrenda)
                {
                    case 0:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 4;
                            case 1:
                                return 3;
                            case 2:
                                return 1;
                            case 3:
                                return 3;
                            case 4:
                                return 1;
                        }
                        break;
                    case 1:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 3;
                            case 1:
                                return 4;
                            case 2:
                                return 3;
                            case 3:
                                return 4;
                            case 4:
                                return 4;
                        }
                        break;
                    case 2:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 1;
                            case 1:
                                return 1;
                            case 2:
                                return 1;
                            case 3:
                                return 1;
                            case 4:
                                return 2;
                        }
                        break;
                    case 3:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 1;
                            case 1:
                                return 1;
                            case 2:
                                return 4;
                            case 3:
                                return 2;
                            case 4:
                                return 1;
                        }
                        break;
                    case 4:
                        switch (PrendaSeleccionada)
                        {
                            case 0:
                                return 5;
                            case 1:
                                return 5;
                            case 2:
                                return 5;
                            case 3:
                                return 5;
                            case 4:
                                return 5;
                        }
                        break;
                }
                break;
        }

        return 0;
    }

   

    public void Next(int filaDeRopa)
    {
        switch(filaDeRopa)
        {
            case 1:
                numeroDePelo = SumarORestar(numeroDePelo, true);
                break;
            case 2:
                numeroDeAccesorio = SumarORestar(numeroDeAccesorio, true);
                break;
            case 3:
                numeroDeCamisa = SumarORestar(numeroDeCamisa, true);
                break;
            case 4:
                numeroDePantalon = SumarORestar(numeroDePantalon, true);
                break;
            case 5:
                numeroDeCalzado = SumarORestar(numeroDeCalzado, true);
                break;
            default:
                break;
        }
    }

    public void Back(int filaDeRopa)
    {
        switch (filaDeRopa)
        {
            case 1:
                numeroDePelo = SumarORestar(numeroDePelo, false);
                break;
            case 2:
                numeroDeAccesorio = SumarORestar(numeroDeAccesorio, false);
                break;
            case 3:
                numeroDeCamisa = SumarORestar(numeroDeCamisa, false);
                break;
            case 4:
                numeroDePantalon = SumarORestar(numeroDePantalon, false);
                break;
            case 5:
                numeroDeCalzado = SumarORestar(numeroDeCalzado, false);
                break;
            default:
                break;
        }
    }

    public int SumarORestar(int valor, bool sumar)
    {
        if(sumar == true)
        {
            valor++;
            //El valor maximo del arreglo
            if(valor>= 5)
            {
                valor = 0;
            }
        }
        else
        {
            valor--;
            if (valor < 0)
            {
                //La posicion maxima del arreglo
                valor = 4;
            }
        }
        return valor;
    }

    public void ChangeColor(Image conjunto, int index)
    {
        switch(index)
        {
            case 0:
                conjunto.color = Color.white;
                break;
            case 1:
                conjunto.color = Color.red;
                break;
            case 2:
                conjunto.color = Color.blue;
                break;
            case 3:
                conjunto.color = Color.yellow;
                break;
            case 4:
                conjunto.color = Color.green;
                break;
            default:
                break;
        }

    }
}
