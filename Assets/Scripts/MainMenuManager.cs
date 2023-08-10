using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{ 
    public static MainMenuManager mainMenuManager = null;
    private static string prevScene = "";
    void Awake() {
            mainMenuManager = this;
    }
    public void ChangeScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
    public void ChangeScene(string sceneName, string curScene){
        prevScene = curScene;
        SceneManager.LoadScene(sceneName);
    }
    public void LoadPrevScene()
    {
        SceneManager.LoadScene(prevScene);
    }
    public void ExitGame(){
        Application.Quit();
    }
}
