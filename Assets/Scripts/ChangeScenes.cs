using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{

    public string[] sceneNames;

    public void ReturnToMainScene()
    {
        SceneManager.LoadScene("scene-MainMenu");
    }

    public void LoadNewScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); 
    }

    public void LoadNewScene1()
    {
        SceneManager.LoadScene("scene1");
    }


}
