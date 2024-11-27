using UnityEngine;
using UnityEngine.SceneManagement;  // Para cargar escenas
using UnityEngine.UI;             // Para interactuar con UI

public class MenuController : MonoBehaviour
{
    // Función para empezar el juego
    public void PlayGame()
    {
        // Cargar la escena principal (asegúrate de tener una escena llamada "MainScene")
        SceneManager.LoadScene("MainScene");
    }

    // Función para mostrar el lore
    public void ShowLore()
    {
        // Aquí puedes agregar la lógica para mostrar el lore (por ejemplo, abrir un panel con el texto)
        Debug.Log("Mostrando el lore del juego...");
    }

    // Función para mostrar el tutorial
    public void ShowTutorial()
    {
        // Aquí puedes agregar la lógica para mostrar el tutorial
        Debug.Log("Mostrando el tutorial...");
    }
}
