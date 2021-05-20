using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Vuforia;

public class Tracking : MonoBehaviour
{
    private bool isDone = false;
    public GameObject inbetweenPrefab;

    private GameObject clone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
        // Get the Vuforia StateManager
        StateManager sm = TrackerManager.Instance.GetStateManager ();

        // Query the StateManager to retrieve the list of
        // currently 'active' trackables 
        //(i.e. the ones currently being tracked by Vuforia)
        IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();
        
        if (activeTrackables.Count() == 2 && !isDone)
        {
            var transform1 = transform;
            clone = (GameObject) Instantiate(inbetweenPrefab, transform1.position, transform1.rotation, inbetweenPrefab.transform.parent);
            clone.transform.localScale = new Vector3(.1f, .1f, .1f);
            isDone = true;
        }
        
        else if (activeTrackables.Count() < 2)
        {

            isDone = false;
        }

        

        // Iterate through the list of active trackables
      //  Debug.Log ("List of trackables currently active (tracked): ");
        foreach (TrackableBehaviour tb in activeTrackables) {
          //  Debug.Log("Trackable: " + tb.TrackableName);
        }
    }
}
