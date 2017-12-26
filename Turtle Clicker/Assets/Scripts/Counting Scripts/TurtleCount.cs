using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleCount : MonoBehaviour
{
    private float turtles = 0;
    private float singleTurtleTanks = 0;
    private float singleTurtleTankPrice = 20;
    private float singleTurtleTankProduction = 1;
    private float TPS = 0;
    private void Start()
    {
        StartCoroutine(AddFromStt());
    }
    public float GetAmount()
    {
        return turtles;
    }
    public string GetAmountAsString()
    {
        return turtles.ToString();
    }
    public void AddAmount(float amount = 1f)
    {
        turtles += amount;
        Round();
    }
    public void RemoveAmount(float amount = 1f)
    {
        turtles -= amount;
        Round();
    }
    private void Round ()
    {
        turtles = Mathf.RoundToInt(turtles);
    }
    public float GetAmountOfSTT()
    {
        return singleTurtleTanks;
    }
    public void AddSTT(float amount = 1f)
    {
        singleTurtleTanks += amount;
        singleTurtleTanks = Mathf.RoundToInt(singleTurtleTanks);
        SetTPS();
    }
    public float GetPriceOfSTT()
    {
        return singleTurtleTankPrice;
    }
    public void AddPriceOfSTT(float amount = 1)
    {
        singleTurtleTankPrice += amount;
        singleTurtleTankPrice = Mathf.RoundToInt(singleTurtleTankPrice);
    }
    private void SetTPS()
    {
        TPS = 0;
        TPS += singleTurtleTankProduction * singleTurtleTanks;
        singleTurtleTanks = Mathf.RoundToInt(singleTurtleTanks);
    }
    public float GetTPS()
    {
        return TPS;
    }
    private IEnumerator AddFromStt()
    {
        while (1 == 1)
        {
            if (singleTurtleTanks != 0)
            {
                turtles += singleTurtleTankProduction;
                yield return new WaitForSeconds(1 / singleTurtleTanks);
            } else yield return new WaitForSeconds(1);
        }
    }
}