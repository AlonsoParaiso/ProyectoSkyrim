using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
    public void ExitGame()//hace que salga del juego
    {
        GameManager.instance.ExitGame();
    }

    public void LoadScene(string sceneName)//carga la escena a la que el boton este asignada
    {
        GameManager.instance.LoadScene(sceneName);
    }

    public void SetName() {
        FindObjectOfType<TMP_InputField>().textViewport.value;
    }

}
