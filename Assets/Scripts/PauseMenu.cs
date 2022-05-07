using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour

{
    //Script Serialization is the automatic process of transforming data sructures or object states into a format that Unity can store and 
    //reconstruct late. This have impact on the performance of the project
    [SerializeField] GameObject breakButton;

    public void Pause()
    {
        breakButton.SetActive(true);
        //Time.timeScale define how the time passes, e.g. timeScale=0 means game pauses
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        breakButton.SetActive(false);
        Time.timeScale = (1f);
    }

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
