using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonController : MonoBehaviour
{

    [SerializeField] private GameObject startButton;
    [SerializeField] private GameObject exitButton;
    [SerializeField] private GameObject settingsButton;
    [SerializeField] private GameObject enterButton;
    [SerializeField] private GameObject accountButton;


    public void EnterButton()
    {
        enterButton.SetActive(false);
        accountButton.SetActive(false);
        startButton.SetActive(true);
        exitButton.SetActive(true);
        settingsButton.SetActive(true);
    }

    public void SettingsButton()
    {
        
    }
    
    public void StartButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;

    }

    public void ExitButton()
    {
        Application.Quit();
    }




}
