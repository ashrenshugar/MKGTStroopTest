using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    //loads test scene
    public void TestScene()
    {
        SceneManager.LoadScene(1);
    }

    //exits game
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }

}
