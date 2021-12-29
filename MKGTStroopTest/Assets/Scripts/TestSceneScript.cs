using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestSceneScript : MonoBehaviour
{
    public GameObject instructions;
    public GameObject Results;
    public GameObject GamePanel;

    public Text timerText;
    public Text colourQuestion;

    public float timeRemaining = 30;
    public bool timerIsRunning = false;
    
    public string colourColour;
    public string wordColour;
    
   


    public void StartGame()
    {
        instructions.SetActive(false);
        GamePanel.SetActive(true);

        timerIsRunning = true;
        RandomColour();
    }


    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                GamePanel.SetActive(false);
                Results.SetActive(true);
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}", seconds);

    }

    void RandomColour()
    {
        int chosencolor = Random.Range(0, 4);

        switch (chosencolor)
        {
            case 0:
                //red
                colourColour = "Red";
                colourQuestion.color = Color.red;
                break;
            case 1:
                //green
                colourColour = "Green";
                colourQuestion.color = Color.green;
                break;
            case 2:
                //blue
                colourColour = "Blue";
                colourQuestion.color = Color.blue;
                break;
            case 3:
                //yellow
                colourColour = "Yellow";
                colourQuestion.color = Color.yellow;
                break;
        }

        int chosenword = Random.Range(0, 4);

        switch (chosenword)
        {
            case 0:
                //red
                wordColour = "Red";
                colourQuestion.text = "Red";
                break;
            case 1:
                //green
                wordColour = "Green";
                colourQuestion.text = "Green";
                break;
            case 2:
                //blue
                wordColour = "Blue";
                colourQuestion.text = "Blue";
                break;
            case 3:
                //yellow
                wordColour = "Yellow";
                colourQuestion.text = "Yellow";
                break;
        }

        if (wordColour == colourColour)
        {
            Debug.Log("word and colour are the same");
            RandomColour();
        }
    }
}
