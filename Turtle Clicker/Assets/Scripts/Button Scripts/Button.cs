using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
    GameObject count;
    private void Start()
    {
        count = GameObject.Find("Count");
    }
    public void ClickedOn()
    {
        count.GetComponent<TurtleCount>().AddAmount();
    }
}
