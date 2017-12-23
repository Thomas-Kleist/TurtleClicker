using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSpawner : MonoBehaviour
{
    
    public void Start()
    {
        GameObject Camera = GameObject.Instantiate((GameObject)Resources.Load("Camera/Camera"));
        Camera.name = "Camera";
        GameObject count = GameObject.Instantiate((GameObject)Resources.Load("Counts/Count"));
        count.name = "Count";
        GameObject uidisplay = GameObject.Instantiate((GameObject)Resources.Load("UI/Canvas"));
        uidisplay.name = "Canvas";
        GameObject Event = GameObject.Instantiate((GameObject)Resources.Load("UI/EventSystem"));
        Event.name = "EventSystem";
        GameObject.Destroy(this.gameObject);
    }
}