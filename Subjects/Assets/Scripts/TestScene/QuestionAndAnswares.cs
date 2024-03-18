using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionAndAnswares : MonoBehaviour
{


    public string[] questions = {
        "What is the capital of Japan?",
        "Who painted the Mona Lisa?",
        "What is the chemical symbol for water?"
    };

    public string[][] answers = {
        new string[]{"Tokyo", "Seoul", "Beijing"},
        new string[]{"Leonardo da Vinci", "Vincent van Gogh", "Pablo Picasso"},
        new string[]{"H2O", "CO2", "NaCl"}
    };

    public string[] FirtstAnswers;
    public string[] SecondAnswers;
    public string[] ThirdAnswers;

    [Range(0, 2)]
    public int[] correctAnswersIndex = { 0, 0, 0 };

    private void Start()
    {
        answers[0] = FirtstAnswers;
        answers[1] = SecondAnswers;
        answers[2] = ThirdAnswers;

    }


}
