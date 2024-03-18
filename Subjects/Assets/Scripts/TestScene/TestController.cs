using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestController : MonoBehaviour
{
    public TMP_Text questionText;
    public TMP_Text[] answerButtons;

    private List<Tuple<string, string[]>> questionAnswerPairs = new List<Tuple<string, string[]>>();
    private int currentQuestionIndex = 0;
    private int correctAnswersCount = 0;

    void Start()
    {
        InitializeQuestions();
        SetQuestion(currentQuestionIndex);
    }

    void InitializeQuestions()
    {
        // Populate the list with questions and their answers
        questionAnswerPairs.Add(new Tuple<string, string[]>("What is the capital of France?", new string[] { "Paris", "Berlin", "London" }));
        questionAnswerPairs.Add(new Tuple<string, string[]>("Who painted the Mona Lisa?", new string[] { "Leonardo da Vinci", "Pablo Picasso", "Vincent van Gogh" }));
        questionAnswerPairs.Add(new Tuple<string, string[]>("What is the tallest mountain in the world?", new string[] { "Mount Everest", "K2", "Kangchenjunga" }));

        // Shuffle the list of questions and answers
        ShuffleQuestions();
    }

    void ShuffleQuestions()
    {
        System.Random rng = new System.Random();
        int n = questionAnswerPairs.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            var value = questionAnswerPairs[k];
            questionAnswerPairs[k] = questionAnswerPairs[n];
            questionAnswerPairs[n] = value;
        }
    }

    void SetQuestion(int index)
    {
        if (index < questionAnswerPairs.Count)
        {
            questionText.text = questionAnswerPairs[index].Item1;

            for (int i = 0; i < answerButtons.Length; i++)
            {
                answerButtons[i].text = questionAnswerPairs[index].Item2[i];
            }
        }
        else
        {
            Debug.Log("Quiz finished! Correct Answers: " + correctAnswersCount);
        }
    }

    public void CheckAnswer(string selectedAnswer)
    {
        string correctAnswer = questionAnswerPairs[currentQuestionIndex].Item2[0]; 

        if (selectedAnswer == correctAnswer)
        {
            Debug.Log("Correct!");
            correctAnswersCount++;
        }
        else
        {
            Debug.Log("Incorrect!");
        }

        // Move to the next question
        currentQuestionIndex++;
        if (currentQuestionIndex < questionAnswerPairs.Count)
        {
            SetQuestion(currentQuestionIndex);
        }
    }
}
