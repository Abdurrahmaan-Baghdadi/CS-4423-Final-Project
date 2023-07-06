using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ChangeScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
    public void ExitGame(){
        Application.Quit();
    }
}
