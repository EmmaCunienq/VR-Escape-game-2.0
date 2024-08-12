using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour
{
    public bool isActive;

    [SerializeField]
    ConditionManager manager;

    public ConditionManager Manager { get => manager; set => manager = value; }

    /*public virtual void DoSomething()
    {

    }*/
}
