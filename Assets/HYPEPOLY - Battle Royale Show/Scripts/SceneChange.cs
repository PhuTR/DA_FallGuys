using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void Update()
    {
       
    }

    public void InGameSceneChange()
    {
        SceneManager.LoadScene("InGame");
    }
    public void StartGameSceneChange()
    {
        SceneManager.LoadScene("Start");
    }
    public void EndGameSceneChange()
    {
  
        SceneManager.LoadScene("Start");
    }
    public void loginGameSceneChange()
    {
        SceneManager.LoadScene("Login");
    }
    public void winGameSceneChange()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("EndGame");
    }
}
