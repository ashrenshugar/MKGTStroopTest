using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public void TestScene()
    {
        SceneManager.LoadScene(1);
    }
    public void TrialScene()
    {
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
        //Debug.Log("Quitting");
    }

}
