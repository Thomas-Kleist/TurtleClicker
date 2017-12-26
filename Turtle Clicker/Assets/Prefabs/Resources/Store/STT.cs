using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STT : MonoBehaviour {
    public GameObject count;
    private void Awake()
    {
        count = GameObject.Find("Count");
    }
    public void ClickedOn()
    {
        if (count.GetComponent<TurtleCount>().GetAmount() >= count.GetComponent<TurtleCount>().GetPriceOfSTT())
        {
            count.GetComponent<TurtleCount>().RemoveAmount(count.GetComponent<TurtleCount>().GetPriceOfSTT());
            count.GetComponent<TurtleCount>().AddSTT();
            count.GetComponent<TurtleCount>().AddPriceOfSTT(count.GetComponent<TurtleCount>().GetPriceOfSTT() * 0.1f);
        }
    }
}