using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionManager : MonoBehaviour
{
    public OpenDoor door;
    public bool isValid = false;

    [SerializeField]
    private List<Condition> conditions = new List<Condition>();


    void Start()
    {
        GetDoor(transform);
        GetConditions(transform);
    }

    void GetDoor(Transform room)
    {
        door = room.GetComponentInChildren<OpenDoor>();
    }

    void GetConditions(Transform room)
    {
        foreach(Condition condition in room.GetComponentsInChildren<Condition>())
        {
            condition.Manager = this;
            conditions.Add(condition);
        }
    }

    public void CheckConditions()
    {
        isValid = true;

        foreach (Condition condition in conditions)
        {
            if (!condition.isActive)
            {
                isValid = false;
                break;
            }
        }


        if (isValid)
        {
            door.Open();
        }
        else
        {
            door.Close();
        }
    }

    void Update()
    {

        
    }
}
