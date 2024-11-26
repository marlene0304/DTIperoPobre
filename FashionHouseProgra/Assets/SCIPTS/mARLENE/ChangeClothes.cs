using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeClothes : MonoBehaviour
{
    // cabello[0]
    //Arreglos de ropa
    public Sprite[] cabello;
    public Sprite[] zapatos;
    public Sprite[] falda;
    public Sprite[] top;
    public Sprite[] accesorio;

    //Numero de la actual prenda
    //No modificar
    public int numCabello, numZapatos, numFalda, numTop, numAccesorio;

    //Aqui va los sprites de la UI
    public Image imagenCabello, imagenAccesorio, imagenTop, imagenFalda, imagenZapatos;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Solo testeo
        /*ChangeColor(imagenCabello, numCabello);
        ChangeColor(imagenAccesorio, numAccesorio);
        ChangeColor(imagenTop, numTop);
        ChangeColor(imagenFalda, numFalda);
        ChangeColor(imagenZapatos, numZapatos);*/

        imagenCabello.sprite = cabello[numCabello];
        imagenAccesorio.sprite = accesorio[numAccesorio];
        imagenTop.sprite = top[numTop];
        imagenFalda.sprite = falda[numFalda];
        imagenZapatos.sprite = zapatos[numZapatos];
    }

    public void Next(int filaDeRopa)
    {
        switch (filaDeRopa)
        {
            case 1:
                numCabello = SumarORestar(numCabello, true);
                break;
            case 2:
                numAccesorio = SumarORestar(numAccesorio, true);
                break;
            case 3:
                numTop = SumarORestar(numTop, true);
                break;
            case 4:
                numFalda = SumarORestar(numFalda, true);
                break;
            case 5:
                numZapatos = SumarORestar(numZapatos, true);
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
                numCabello = SumarORestar(numCabello, false);
                break;
            case 2:
                numAccesorio = SumarORestar(numAccesorio, false);
                break;
            case 3:
                numTop = SumarORestar(numTop, false);
                break;
            case 4:
                numFalda = SumarORestar(numFalda, false);
                break;
            case 5:
                numZapatos = SumarORestar(numZapatos, false);
                break;
            default:
                break;
        }
    }

    public int SumarORestar(int valor, bool sumar)
    {
        if (sumar == true)
        {
            valor++;
            //El valor maximo del arreglo
            if (valor >= 5)
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

    public void ChangeClothe(Image conjunto, int index)
    {
        switch (index)
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
