using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameCont : MonoBehaviour
{
    public Button okbutton;

    public Button restartbutton;

    public InputField answerInputbox;

    public Text displayText;

    string[] answers;

    string[] questions;

    int currentQuestionNumber = 0;

    int currentAnswerNumber = 0;

    void Start()
    {
        restartbutton.gameObject.SetActive(false);
        answers = new string[3];
        questions = new string[]{
            "what is your name?",
            "what is your favourite color?",
            "what is your favourite country?",
            "what is your favourite anime?",
            "what is your favourite animal?",
            "what is your favourite song?",
            "what is your favourite food?",
            "what is your favourite book?",
            "what is your favourite celebriy?",
            "what is your favourite game?",
            "what is your favourite free time?",
            "what is your favourite youtube?",
            "what is your favourite twitch?",
        };

        displayText.text = questions[currentQuestionNumber];
    }

   public void printName()


    {


        answers[currentAnswerNumber] = answerInputbox.text;

        answerInputbox.text = "";

        currentAnswerNumber =currentAnswerNumber + 1;

        currentQuestionNumber = Random.Range(0, questions.Length); 

        if(currentAnswerNumber <= 2){

        displayText.text = questions[currentQuestionNumber];

        }
        else{
            displayText.text = answers[0] + " likes " + answers[1] + " he's like " + answers[2];

            okbutton.gameObject.SetActive(false);
            answerInputbox.gameObject.SetActive(false);
            restartbutton.gameObject.SetActive(true);
        }
    }

    public void restart(){

       SceneManager.LoadScene("w2");

    }

    void Update()
    {


    }
}
