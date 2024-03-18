using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestController : MonoBehaviour
{
    public TextMeshProUGUI questionText;
    public Button[] answerButtons; 
    public TextMeshProUGUI resultText; 
    public Button restartButton; 

    private string[] questions = {
        "What is the capital of Japan?",
        "Who painted the Mona Lisa?",
        "What is the chemical symbol for water?"
    };

    private string[][] answers = {
        new string[]{"Tokyo", "Seoul", "Beijing"}, 
        new string[]{"Leonardo da Vinci", "Vincent van Gogh", "Pablo Picasso"}, 
        new string[]{"H2O", "CO2", "NaCl"}
    };

    private int[] correctAnswersIndex = { 0, 0, 0 };
    private int currentQuestionIndex = 0;
    private int correctAnswersCount = 0;

    void Start()
    {
        LoadQuestion(currentQuestionIndex);
    }

    void LoadQuestion(int questionIndex)
    {
        questionText.text = questions[questionIndex];
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = answers[questionIndex][i];
            int answerIndex = i; 
            answerButtons[i].onClick.RemoveAllListeners(); 
            answerButtons[i].onClick.AddListener(() => CheckAnswer(answerIndex));
        }
    }

    void CheckAnswer(int selectedAnswerIndex)
    {
        if (selectedAnswerIndex == correctAnswersIndex[currentQuestionIndex])
        {
            Debug.Log("Correct answer!");
            correctAnswersCount++;
        }
        else
        {
            Debug.Log("Incorrect answer!");
        }

        currentQuestionIndex++;
        if (currentQuestionIndex < questions.Length)
        {
            LoadQuestion(currentQuestionIndex);
        }
        else
        {
            ShowResult();
        }
    }

    void ShowResult()
    {
        resultText.text = "You answered " + correctAnswersCount + " out of " + questions.Length + " questions correctly.";
        questionText.gameObject.SetActive(false);
        foreach (Button button in answerButtons)
        {
            button.gameObject.SetActive(false);
        }
        restartButton.gameObject.SetActive(true);
    }

    public void RestartQuiz()
    {
        currentQuestionIndex = 0;
        correctAnswersCount = 0;
        questionText.gameObject.SetActive(true);
        foreach (Button button in answerButtons)
        {
            button.gameObject.SetActive(true);
        }
        resultText.text = "";
        restartButton.gameObject.SetActive(false);
        LoadQuestion(currentQuestionIndex);
    }
}
