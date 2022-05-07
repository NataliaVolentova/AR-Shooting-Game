using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
   
    public Text pointsText;
   public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";

       
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
        Score.scoreVal = 0;

        
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Application quit");
    }
}
