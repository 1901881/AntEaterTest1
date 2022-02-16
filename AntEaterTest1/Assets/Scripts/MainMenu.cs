using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");//loads first level
       
    }

    public void QuitGame()
    {
        Application.Quit(); // this line actually quits the application.
       // UnityEditor.EditorApplication.isPlaying = false; //this line quits editor
    }


}
