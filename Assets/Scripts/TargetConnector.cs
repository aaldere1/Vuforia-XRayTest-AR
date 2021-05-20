using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetConnector : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    private bool image1 = false;
    private bool image2 = false;
    public GameObject MiddleMagic;
   //private LineRenderer line;

    public void IsImage1Tracked(bool value)

    {
        image1 = value;

    }

    public void IsImage2Tracked(bool value)
    {

        image2 = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        MiddleMagic.SetActive(false);
     //  line = GetComponent<LineRenderer>();
      //  line.enabled = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (image1 == true && image2 == true)
        {
        //  line.enabled = true;
          //  line.SetPosition(0, target1.position);
          //  line.SetPosition(1, target2.position); 
          
          MiddleMagic.SetActive(true);
          MiddleMagic.transform.position = (target1.position + target2.position) / 2;

        }
        
        else

        {
          // line.enabled = false;
          MiddleMagic.SetActive(false);

        }
        
    }
}
