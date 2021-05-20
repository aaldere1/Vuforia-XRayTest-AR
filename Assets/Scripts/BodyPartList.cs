using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;


public class BodyPartList : MonoBehaviour
{

   /* public Image brainIcon;
    public Transform BrainPosition;
    public Image bladder;
    public Transform BladderPosition;
    public Image heart;
    public Transform heartPosition;
    public Image leftLung;
    public Transform LeftLungPosition;
    public Image rightLung;
    public Transform RightLungPosition;
    public Image rightKidney;
    public Transform RightKidneyPosition;
    public Image leftKidney;
    public Transform LeftKidneyPosition;
    public Image stomach;
    public Transform StomachPosition; */

    public GameObject selectiondazzle;



    // Start is called before the first frame update
    void Start()
    {
        
        selectiondazzle.SetActive(false);
    }

    
    public void ButtonHighlight(Transform pos){
        selectiondazzle.SetActive(true);
        selectiondazzle.transform.position = pos.position;
    }

    /*
      public void OnBrainFound()
        {
            //  brainIcon.enabled = false;

            selectiondazzle.SetActive(true);
            selectiondazzle.transform.position = BrainPosition.position;


        }

      public void OnLeftKidneyFound()

        {

            selectiondazzle.SetActive(true);
            selectiondazzle.transform.position = LeftKidneyPosition.position;


        }

      public void OnRightKidneyFound()

        {

            selectiondazzle.SetActive(true);
            selectiondazzle.transform.position = RightKidneyPosition.position;

        }

      public void OnBladderFound()

        {

            selectiondazzle.SetActive(true);
            selectiondazzle.transform.position = BladderPosition.position;

        }

      public void OnHeartFound()

        {

            selectiondazzle.SetActive(true);
            selectiondazzle.transform.position = heartPosition.position;


        }

      public void OnLeftLungFound()
        {

            selectiondazzle.SetActive(true);
            selectiondazzle.transform.position = LeftLungPosition.position;

        }

      public void OnRightLungFound()
        {

            selectiondazzle.SetActive(true);
            selectiondazzle.transform.position = RightLungPosition.position;

        }

      public void OnStomachFound()

        {

            selectiondazzle.SetActive(true);
            selectiondazzle.transform.position = StomachPosition.position;


        }




        // Update is called once per frame
*/
       

    }



