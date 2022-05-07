// sound effect source: https://www.zapsplat.com/
//credits to Parth Anand for code inspiration

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    //crate the balloon hit function - invisible ray which, when directed on balloon, than balloon get destroyed
    public GameObject arCamera;
    public GameObject smoke;
    


    public void Shoot()
    {
        RaycastHit hit;

        //Physics.Raycas bool returns true if the ray intersects with a collider, otherwise false
        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "Balloon1(Clone)")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));

                //count how many balloons a player shot *10
                //scoreVal is static var so I can point to this var from other
                //classes and share its values
                Score.scoreVal += 10; 
             }
            else
            {
                // if you miss a shot -20 points
                Score.scoreVal -= 20;
            }

        }
        else
        {
            // if you miss a shot -20 points
            Score.scoreVal -= 20;
        }


    }
}
