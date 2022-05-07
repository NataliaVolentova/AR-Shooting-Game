using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBalloon : MonoBehaviour
{
    public float timer; 
    


    public enum GameDifficulty
    {
        Easy,
        Medium,
        Hard,
        Overkill

    }

    public static GameDifficulty theLevel;

    // Update is called once per frame = 60 x / second
    void Update()
    {
        Debug.Log("timer is: " + timer + "s");
        timer += Time.deltaTime;

        if (Score.scoreVal <= 40)
        {
            theLevel = GameDifficulty.Easy;
            Debug.Log("level is: " + theLevel );
        }

        else if (Score.scoreVal >=40 & Score.scoreVal <=80)
        {
            theLevel = GameDifficulty.Medium;
            Debug.Log("timer is: " + timer + "s");
        }

        else if (Score.scoreVal > 80 & Score.scoreVal <= 120)
        {
            theLevel = GameDifficulty.Hard;
            Debug.Log("timer is: " + timer + "s");
        }

        else 
        {
            theLevel = GameDifficulty.Overkill;
            Debug.Log("timer is: " + timer + "s");
        }



        switch (theLevel)
        {
            case GameDifficulty.Easy:

                if (timer <= 10)
                {

                    transform.Translate(Vector3.up * Time.deltaTime * 0.5f);

                }


                else if (timer >= 10)
                {

                    transform.Translate(Vector3.up * Time.deltaTime * 0.8f);
                }

                else
                {
                    transform.Translate(Vector3.up * Time.deltaTime * 1.0f);
                }
                break;

            case GameDifficulty.Medium:
                if (timer <= 10)
                {

                    transform.Translate(Vector3.up * Time.deltaTime * 1.2f);

                }


                else if (timer >= 10)
                {

                    transform.Translate(Vector3.up * Time.deltaTime * 1.4f);
                }

                else
                {
                    transform.Translate(Vector3.up * Time.deltaTime * 1.6f);
                }
                break;

            case GameDifficulty.Hard:
                if (timer <= 10)
                {

                    transform.Translate(Vector3.up * Time.deltaTime * 1.6f);

                }


                else if (timer >= 10)
                {


                    transform.Translate(Vector3.up * Time.deltaTime * 1.6f);
                }

                else
                {
                    transform.Translate(Vector3.up * Time.deltaTime * 1.9f);
                }
                break;

            case GameDifficulty.Overkill:
                if (timer <= 10)
                {


                    transform.Translate(Vector3.up * Time.deltaTime * 2.0f);

                }


                else if (timer >= 10)
                {

                    transform.Translate(Vector3.up * Time.deltaTime * 2.2f);
                }

                else
                {
                    transform.Translate(Vector3.up * Time.deltaTime * 2.4f);
                }
                break;

        }

    }


}
