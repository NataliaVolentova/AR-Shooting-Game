using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour

{
    //public GameObject TimerPicture;
    public int timer;
    public Text TimerDisplay;
    public GameOver GameOver;
   // int maxPlatform = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(TimerStarts());
    }

    IEnumerator TimerStarts()
    {
        yield return new WaitForSeconds(4);

        while (timer > 0)
        {
            TimerDisplay.text = timer.ToString();
            yield return new WaitForSeconds(1f);
            timer--;
        }
        TimerDisplay.text = "GAME OVER";
        //GameController.instance.BeginGame();
        yield return new WaitForSeconds(1f);
        //change of the scene, thats why SetActive no needed
        //TimerDisplay.gameObject.SetActive(false);
        GameOver.Setup(Score.scoreVal);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
