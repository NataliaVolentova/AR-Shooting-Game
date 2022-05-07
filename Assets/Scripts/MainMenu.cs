using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//Music credits: The Beginning(w Caturday) by Babasmas | https://soundcloud.com/babasmasmoosic
//Music promoted by https://www.chosic.com/free-music/all/
//Creative Commons CC BY-SA 3.0
//https://creativecommons.org/licenses/by-sa/3.0/
 
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Application quit");
    }

    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
