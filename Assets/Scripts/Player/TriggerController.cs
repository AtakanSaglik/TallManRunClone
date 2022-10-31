using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TriggerController : MonoBehaviour
{
    [SerializeField] private GameObject restartButton;
    [SerializeField] private GameObject exitButton;
    [SerializeField] private GameObject mainmenuButton;

    public void RestartButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;

    }
    public void MainmenuButton()
    {
        SceneManager.LoadScene(0);

    }


    public void ExitButton()
    {
        Application.Quit();
    }






    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Finish")
        {
            Time.timeScale = 0f;
            restartButton.SetActive(true);
            exitButton.SetActive(true);
            mainmenuButton.SetActive(true);


        }

    }

}
