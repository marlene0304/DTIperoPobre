using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;



public class Menu : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadScene("Juego");
    }
    
    public void ExitGame()
    {
        //No sirve dentro de unity, solo cuando ya es un ejecutable
        Application.Quit();

    }

}
