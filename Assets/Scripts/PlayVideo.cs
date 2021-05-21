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

public class PlayVideo : MonoBehaviour
{

    public GameObject HP1VideoPlane;
    public GameObject HP2VideoPlane;
    public GameObject HP3VideoPlane;
    public GameObject Orb1;
    public GameObject Orb2;
    public GameObject Orb3;
    public GameObject ForceFieldHP1;
    public GameObject sideGhost1;
    


    // Start is called before the first frame update
    void Start()
    {
      
            HP1VideoPlane.SetActive(false);
            HP2VideoPlane.SetActive(false);
            HP3VideoPlane.SetActive(false);
            Orb1.SetActive(false);
            Orb2.SetActive(false);
            Orb3.SetActive(false);
            ForceFieldHP1.SetActive(false);
            sideGhost1.SetActive(false);
    }

    public void PlayHP1Trailer()
    {
       
            HP1VideoPlane.SetActive(true);
            Orb1.SetActive(true);
            ForceFieldHP1.SetActive(true);
            sideGhost1.SetActive(true);
        
       
    }
    
    public void PlayHP2Trailer()
    {
        HP2VideoPlane.SetActive(true);
        Orb2.SetActive(true);
        ForceFieldHP1.SetActive(true);
        sideGhost1.SetActive(true);
    }
    
    public void PlayHP3Trailer()
    {
        HP3VideoPlane.SetActive(true);
        Orb3.SetActive(true);
        ForceFieldHP1.SetActive(true);
        sideGhost1.SetActive(true);
    }

    public void HP1Close()
    {
        HP1VideoPlane.SetActive(false);
        Orb1.SetActive(false);
        ForceFieldHP1.SetActive(false);
        sideGhost1.SetActive(false);
    }
    
    public void HP2Close()
    {
        HP2VideoPlane.SetActive(false);
        Orb2.SetActive(false);
        ForceFieldHP1.SetActive(false);
        sideGhost1.SetActive(false);
    }
    
    public void HP3Close()
    {
        HP3VideoPlane.SetActive(false);
        Orb3.SetActive(false);
        ForceFieldHP1.SetActive(false);
        sideGhost1.SetActive(false);
    }

    
}
   
  

