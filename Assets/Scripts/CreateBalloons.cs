using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBalloons : MonoBehaviour
{
    //create the place where the objects will be created - use the coordinates and store them in an array
    public Transform[] originPoints;
    public GameObject[] balloons;
    public int i;
    public int count;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NewBalloons());
    }
    
    //IEnumerator stops the process at a specific time, return that part and gets back to that point
    IEnumerator NewBalloons()
    {
        //count = (count + 3);
        //Debug.Log("sum of balloons: " + count);

        yield return new WaitForSeconds(3);
        for ( i=0; i<3; i++)
        {
            Instantiate(balloons[i], originPoints[i].position, Quaternion.identity);
        }
        StartCoroutine(NewBalloons());
        
    }


    // Update is not called here
}
