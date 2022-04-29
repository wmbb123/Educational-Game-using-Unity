using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtractionManager : MonoBehaviour
{
    public Text[] numbersText = new Text[2];
    public int[] numbers = new int[2];

    public float time;
    public float roundLength;
    public Text timerText;

    public Button[] buttons;

    public float[] AnswerSubtraction;
    public float ResultSubtraction;

    public float score;
    public Text scoreText;
    public Text summaryText;
    public float errorscore;
    public Text TotalsummaryText;

    void Start()
    {
        time = 0.1f;
    }

    void Update()
    {
        time -= Time.deltaTime;
        timerText.text = "TIME : " + time.ToString("0");
        displayResults();

        if (time <= 0)
        {
            time = roundLength;
            randomNums();
            ResultSubtraction = numbers[0] - numbers[1];
            displayResults();

            AnswerSubtraction[0] = ResultSubtraction;
            AnswerSubtraction[1] = ResultSubtraction + Random.Range(1, 10);
            AnswerSubtraction[2] = ResultSubtraction - Random.Range(1, 10);

            ShuffleArray(AnswerSubtraction);

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].image.color = Color.white;
            }
        }
    }

    public void sum()
    {
        summaryText.text = "Correct: " + numbers[0] + " - " + numbers[1] + " = " + ResultSubtraction;

    }
    public void incorrectsum()
    {
        summaryText.text = "Incorrect: " + numbers[0] + " - " + numbers[1] + " = " + ResultSubtraction;

    }
    public void TotalSummary()
    {
        TotalsummaryText.text = "Well Done! You received " + score + " points and only got " + errorscore + " wrong!";
    }
    void randomNums()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Random.Range(10, 100);
            numbersText[i].text = numbers[i].ToString();
        }
    }

    void displayResults()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].transform.GetChild(0).GetComponent<Text>().text = AnswerSubtraction[i].ToString();
        }
    }

    public static void ShuffleArray<T>(T[] arr)
    {
        for (int i = arr.Length - 1; i > 0; i--)
        {
            int r = Random.Range(0, i);
            T tmp = arr[i];
            arr[i] = arr[r];
            arr[r] = tmp;
        }
    }

    public void ButtonCheck(int buttonNum)
    {
        if (buttons[buttonNum].transform.GetChild(0).GetComponent<Text>().text == ResultSubtraction.ToString())
        {
            Debug.Log("Correct!");
            buttons[buttonNum].image.color = Color.green;
            score += 1;
            scoreText.text = "SCORE : " + score.ToString("0");
            sum();
            if (score == 5)
            {
                TotalSummary();
            }
        }
        else
        {
            Debug.Log("Wrong!");
            buttons[buttonNum].image.color = Color.red;
            score -= 1;
            errorscore += 1;
            if (score <= 0)
            {
                score = 0;
            }
            scoreText.text = "SCORE : " + score.ToString("0");
            incorrectsum();
        }
        time = 0.3f;
    }
}
