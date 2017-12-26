using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TPSNumberReader : MonoBehaviour {
    public GameObject count;
    private void Awake()
    {
        count = GameObject.Find("Count");
    }
    private void Update()
    {
        this.GetComponent<Text>().text = "Per Second: " + count.GetComponent<TurtleCount>().GetTPS().ToString();
    }
}
