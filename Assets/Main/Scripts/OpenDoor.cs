using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Transform grill;

    Vector3 grillOriginalPosition;

    IEnumerator grillMoving;

    private void Start()
    {
        grillOriginalPosition = grill.localPosition;
    }

    public void Open()
    {
        
        //grill.localPosition = new Vector3 (grill.localPosition.x, grill.localPosition.y + 2.35f, grill.localPosition.z);

        if(grillMoving != null)
        {
            StopCoroutine(grillMoving);
        }

        grillMoving = LerpPosition(grill, new Vector3(grillOriginalPosition.x, grillOriginalPosition.y + 2.35f, grillOriginalPosition.z), 1f);

        StartCoroutine(grillMoving);
    }

    public void Close()
    {


        if (grillMoving != null)
        {
            StopCoroutine(grillMoving);
        }

        grillMoving = LerpPosition(grill, grillOriginalPosition, 1f);

        StartCoroutine(grillMoving);

    }


    IEnumerator LerpPosition(Transform obj, Vector3 targetPosition, float duration)
    {
        float time = 0f;

        Vector3 currentPosition = obj.localPosition;

        while (time < duration)
        {
            time += Time.deltaTime;

            obj.localPosition = Vector3.Lerp(currentPosition, targetPosition, time / duration);

            yield return null;
        }

        obj.localPosition = targetPosition;
    }
}