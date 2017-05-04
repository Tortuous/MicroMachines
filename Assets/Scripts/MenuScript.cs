using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip audioclipMenu;
    public AudioClip audioclipGame;

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        if(sceneName == "Track1")
        {
            audiosource.clip = audioclipGame;
        }
        if(sceneName == "Track2")
        {
            audiosource.clip = audioclipGame;
        }
        if(sceneName == "MainMenu")
        {
            audiosource.clip = audioclipMenu;
        }
        if(sceneName == "Options")
        {
            audiosource.clip = audioclipMenu;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}