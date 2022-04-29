using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("ChooseLevel");
    }
    public void AboutUs()
    {
        SceneManager.LoadScene("AboutUs");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Back()
    {
        SceneManager.LoadScene("MAINMENU");
    }
    public void Addition()
    {
        SceneManager.LoadScene("ADD");
    }
    public void HowAddition()
    {
        SceneManager.LoadScene("HowToPlayADD");
    }
    public void HowSubtraction()
    {
        SceneManager.LoadScene("HowToPlaySUB");
    }
    public void HowMultiplication()
    {
        SceneManager.LoadScene("HowToPlayMULTI");
    }
    public void HowDivision()
    {
        SceneManager.LoadScene("HowToPlayDIV");
    }
    public void Subtraction()
    {
        SceneManager.LoadScene("SUB");
    }
    public void Multiplication()
    {
        SceneManager.LoadScene("MULTI");
    }
    public void Division()
    {
        SceneManager.LoadScene("DIVISION");
    }
    public void BIDMAS()
    {
        SceneManager.LoadScene("BIDMAS");
    }
    public void HowBIDMAS()
    {
        SceneManager.LoadScene("HowToPlayBIDMAS");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
