using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STTNumberReader : MonoBehaviour {
    public GameObject count;
    private void Awake()
    {
        count = GameObject.Find("Count");
    }
    private void Update()
    {
        this.GetComponent<Text>().text = "Costs: " + count.GetComponent<TurtleCount>().GetPriceOfSTT().ToString() + "\nYou Have: " + count.GetComponent<TurtleCount>().GetAmountOfSTT().ToString();
    }
}
