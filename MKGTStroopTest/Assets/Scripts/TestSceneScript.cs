using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestSceneScript : MonoBehaviour
{
    //variables
    //in-game panels
    public GameObject instructions;
    public GameObject Results;
    public GameObject GamePanel;

    //text
    public Text timerText;
    public Text colourQuestion;
    public Text correctResult;
    public Text incorrectResult;
    public Text totalResult;


    //timer variables
    public float timeRemaining = 30;
    public bool timerIsRunning = false;
    
    //global variables
    public string colourColour;
    public string wordColour;
    public int correct = 0;
    public int incorrect = 0;
    public int totalQuestions = 0;
    
   
    public void StartGame()
    {
        //closes instructions panel and starts game
        instructions.SetActive(false);
        GamePanel.SetActive(true);

        //start timer
        timerIsRunning = true;

        //changes main word to random colour and word
        RandomColour();
    }


    void Update()
    {
        //checks if timer is running
        if (timerIsRunning)
        {
            //checks if time is remaining
            if (timeRemaining > 0)
            {
                //adjusts time
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                //game ended
                //sets game panel to false and result panel to true
                GamePanel.SetActive(false);
                Results.SetActive(true);

                // set remainin time to exactly 0 and stops timer
                timeRemaining = 0;
                timerIsRunning = false;
                EndGame();
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        //displays seconds in 2 number format
        timerText.text = string.Format("{0:00}", seconds);

    }

    void RandomColour()
    {
        //choses a random number between 0 and 3
        int chosencolor = Random.Range(0, 4);

        switch (chosencolor)
        {
            case 0:
                //sets colourColour variable to red for checking
                colourColour = "Red";
                //turns word colour to red
                colourQuestion.color = Color.red;
                break;
            case 1:
                //sets colourColour variable to green for checking
                colourColour = "Green";
                //turns word colour to green
                colourQuestion.color = Color.green;
                break;
            case 2:
                //sets colourColour variable to blue for checking
                colourColour = "Blue";
                //turns word colour to blue
                colourQuestion.color = Color.blue;
                break;
            case 3:
                //sets colourColour variable to yellow for checking
                colourColour = "Yellow";
                //turns word colour to yellow
                colourQuestion.color = Color.yellow;
                break;
        }

        //choses a random number between 0 and 3
        int chosenword = Random.Range(0, 4);

        switch (chosenword)
        {
            case 0:
                //sets wordColour variable to red for checking
                wordColour = "Red";
                //turns word text to red
                colourQuestion.text = "Red";
                break;
            case 1:
                //sets wordColour variable to green for checking
                wordColour = "Green";
                //turns word text to green
                colourQuestion.text = "Green";
                break;
            case 2:
                //sets wordColour variable to blue for checking
                wordColour = "Blue";
                //turns word text to blue
                colourQuestion.text = "Blue";
                break;
            case 3:
                //sets wordColour variable to yellow for checking
                wordColour = "Yellow";
                //turns word text to yellow
                colourQuestion.text = "Yellow";
                break;
        }

        //compares wordColour and colourColour to make sure that they are different i.e the word and colour cannot be red
        if (wordColour == colourColour)
        {
            Debug.Log("word and colour are the same");
            //if the colour and word is the same, the method is run again to change them to a different combination
            RandomColour();
        }
    }

    public void CheckRed()
    {
        if(colourColour == "Red")
        {
            correct = correct + 1;
            totalQuestions = totalQuestions + 1;
            RandomColour();
        } else
        {
            incorrect = incorrect + 1;
            totalQuestions = totalQuestions + 1;
            RandomColour();
        }
    }
    public void CheckBlue()
    {
        if (colourColour == "Blue")
        {
            correct = correct + 1;
            totalQuestions = totalQuestions + 1;
            RandomColour();
        }
        else
        {
            incorrect = incorrect + 1;
            totalQuestions = totalQuestions + 1;
            RandomColour();
        }
    }
    public void CheckGreen()
    {
        if (colourColour == "Green")
        {
            correct = correct + 1;
            totalQuestions = totalQuestions + 1;
            RandomColour();
        }
        else
        {
            incorrect = incorrect + 1;
            totalQuestions = totalQuestions + 1;
            RandomColour();
        }
    }
    public void CheckYellow()
    {
        if (colourColour == "Yellow")
        {
            correct = correct + 1;
            totalQuestions = totalQuestions + 1;
            RandomColour();
        }
        else
        {
            incorrect = incorrect + 1;
            totalQuestions = totalQuestions + 1;
            RandomColour();
        }
    }

    void EndGame()
    {
        correctResult.text = correct.ToString();
        incorrectResult.text = incorrect.ToString();
        totalResult.text = totalQuestions.ToString();
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
