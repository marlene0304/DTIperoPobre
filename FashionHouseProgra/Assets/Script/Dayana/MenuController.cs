using UnityEngine;
using UnityEngine.SceneManagement;  // Para cargar escenas
using UnityEngine.UI;             // Para interactuar con UI

public class MenuController : MonoBehaviour
{
    // Funci�n para empezar el juego
    public void PlayGame()
    {
        // Cargar la escena principal (aseg�rate de tener una escena llamada "MainScene")
        SceneManager.LoadScene("MainScene");
    }

    // Funci�n para mostrar el lore
    public void ShowLore()
    {
        // Aqu� puedes agregar la l�gica para mostrar el lore (por ejemplo, abrir un panel con el texto)
        Debug.Log("Mostrando el lore del juego...");
    }

    // Funci�n para mostrar el tutorial
    public void ShowTutorial()
    {
        // Aqu� puedes agregar la l�gica para mostrar el tutorial
        Debug.Log("Mostrando el tutorial...");
    }
}
