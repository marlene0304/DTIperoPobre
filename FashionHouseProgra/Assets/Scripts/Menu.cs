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
        
        Application.Quit();

    }

}
