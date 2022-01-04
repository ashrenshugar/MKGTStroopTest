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
    public float currentTime = 0;
    
    
    //global variables
    public string colourColour;
    public string wordColour;
    public int correct = 0;
    public int incorrect = 0;
    public int questionsLeft = 30;
    public bool gamestarted = false;


    public void StartGame()
    {
        //set all variables to default
        correct = 0;
        incorrect = 0;
        questionsLeft = 30;
        currentTime = 0;

        //closes instructions panel and result panel and opens game panel
        instructions.SetActive(false);
        Results.SetActive(false);
        GamePanel.SetActive(true);

        //start game
        gamestarted = true;

        //changes main word to random colour and word
        RandomColour();
    }


    void Update()
    {
        //checks if the game has started
        if (gamestarted)
        {
            //checks if questions are remaining
            if (questionsLeft == 0)
            {
                //game ended
                //sets game panel to false and result panel to true
                GamePanel.SetActive(false);
                Results.SetActive(true);

                // ends the game

                gamestarted = false;
                EndGame();
            }
            else
            {
                //adjusts time
                currentTime += Time.deltaTime;
                DisplayTime(currentTime);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);

        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        //displays time to timer
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        //displays time to result time
        totalResult.text = string.Format("{0:00}:{1:00}", minutes, seconds);

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

    //"red" button pushed
    public void CheckRed()
    {
        //checks is colour is red
        if(colourColour == "Red")
        {
            //correct
            //adds to correct amount
            correct = correct + 1;
            //deducts 1 from questions answered
            questionsLeft = questionsLeft - 1;
            //randomizes new colour/word combo
            RandomColour();
        } else
        {
            //incorrect
            //add to incorrect amount
            incorrect = incorrect + 1;
            //deducts 1 from questions answered
            questionsLeft = questionsLeft - 1;
            //randomizes new colour/word combo
            RandomColour();
        }
    }

    //"blue" button pushed
    public void CheckBlue()
    {
        //checks is colour is blue
        if (colourColour == "Blue")
        {
            //correct
            //adds to correct amount
            correct = correct + 1;
            //deducts 1 from questions answered
            questionsLeft = questionsLeft - 1;
            //randomizes new colour/word combo
            RandomColour();
        }
        else
        {
            //incorrect
            //add to incorrect amount
            incorrect = incorrect + 1;
            //deducts 1 from questions answered
            questionsLeft = questionsLeft - 1;
            //randomizes new colour/word combo
            RandomColour();
        }
    }

    //"green" button pushed
    public void CheckGreen()
    {
        //checks is colour is green
        if (colourColour == "Green")
        {
            //correct
            //adds to correct amount
            correct = correct + 1;
            //deducts 1 from questions answered
            questionsLeft = questionsLeft - 1;
            //randomizes new colour/word combo
            RandomColour();
        }
        else
        {
            //incorrect
            //add to incorrect amount
            incorrect = incorrect + 1;
            //deducts 1 from questions answered
            questionsLeft = questionsLeft - 1;
            //randomizes new colour/word combo
            RandomColour();
        }
    }

    //"yellow" button pushed
    public void CheckYellow()
    {
        //checks is colour is yellow
        if (colourColour == "Yellow")
        {
            //correct
            //adds to correct amount
            correct = correct + 1;
            //deducts 1 from questions answered
            questionsLeft = questionsLeft - 1;
            //randomizes new colour/word combo
            RandomColour();
        }
        else
        {
            //incorrect
            //add to incorrect amount
            incorrect = incorrect + 1;
            //deducts 1 from questions answered
            questionsLeft = questionsLeft - 1;
            //randomizes new colour/word combo
            RandomColour();
        }
    }

    void EndGame()
    {
        //displays correct amount answered
        correctResult.text = correct.ToString() + " /30";
        //displays incrrect amount answered
        incorrectResult.text = incorrect.ToString() + " /30";
        
    }

    public void ReturnToMenu()
    {
        //returns to main menu
        SceneManager.LoadScene(0);
    }
}
