using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveLever : Condition
{

    public void turnOn()
    {
        isActive = true;
        Manager.CheckConditions();

    }

    public void turnOff()
    {
        isActive = false;
        Manager.CheckConditions();
    }
}