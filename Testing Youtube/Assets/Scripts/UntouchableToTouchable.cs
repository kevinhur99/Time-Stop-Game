using UnityEngine;
using System.Collections;

public class UntouchableToTouchable : TimeBody
{
    // Update is called once per frame
    void Update()
    {

    }

    public void ContinueTime()
    {
        base.ContinueTime();
        Debug.Log("Continued!");
    }
}
