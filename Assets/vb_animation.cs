using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class vb_animation : MonoBehaviour//, IVirtualButtonEventHandler 
{

    public GameObject vbBtnObj;
    public Animator cubeAni; //cube
    
    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("Laciebtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>();

    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("BTN Pressed");
    }

    public void onButtonReleased(VirtualButtonBehaviour vb)
    {
        SceneManager.LoadScene("none");
        Debug.Log("BTN Released");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
