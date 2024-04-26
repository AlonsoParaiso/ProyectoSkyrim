using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //el game manager controla las variables del juego y es accesible a todos
    private float time;
    private int life;
    public Character character;
    private string name;
    public enum GameManagerVariables { TIME, LIFE };//para facilitar el codigo

    private void Awake()
    {
        if (!instance)
        {
            instance = this;//se instancia el objecto
            DontDestroyOnLoad(gameObject);// no se destruye entre cargas
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        time += Time.deltaTime;
    }

    // getter
    public float GetTime()
    {
        return time;
    }

    public void SetName(string name) 
    {
        this.name = name;
    }

    public string GetName() { return name; }
    // getter
    public int GetLife()
    {
        return life;
    }


    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        
    }
    
    public void ExitGame() 
    {
        Debug.Log("Me cerraste wey");
        Application.Quit();
    }

    public void SelectCharacter()
    {
        TMP_Dropdown dropdown = FindObjectOfType<TMP_Dropdown>();
        if (dropdown.value == 0)
        {
            character = new Cowboy(name);
        }
        else if (dropdown.value == 1)
        {
            character = new Wizard(2.5f , name);
        }
    }

}