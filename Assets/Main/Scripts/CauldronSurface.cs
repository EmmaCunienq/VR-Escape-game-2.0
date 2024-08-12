using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronSurface : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"ça collide avec {other.name} - {other.GetComponent<flask>()}");
        if ( other.GetComponentInParent<flask>() )
       // if (other.TryGetComponent<flask>(out flask thisFlask))
        {
            flask thisFlask = other.GetComponentInParent<flask>();
            Debug.Log("c'est une potion");
            GetComponentInParent<Cauldron>().ChangeColor(thisFlask.potionColor);
            Destroy(other.gameObject);
        }
    }
}
