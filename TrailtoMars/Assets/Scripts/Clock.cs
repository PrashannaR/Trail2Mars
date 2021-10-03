using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public GameObject minuteHand;
    public GameObject hourHand;
    float rotateX = 0f;

    float rotateMin = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float clockMove = 1f;
        rotateX += clockMove; 

        hourHand.transform.Rotate(clockMove, 0f, 0f);


        float minMove = 3f;
        rotateMin += minMove;
        
        minuteHand.transform.Rotate(minMove, 0f, 0f);
        
        


    }//update

    

}
