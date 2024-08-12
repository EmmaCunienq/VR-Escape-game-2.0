using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flask : MonoBehaviour
{
    public Color potionColor;

    /*void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Potion"))
        {
            Potion potion = other.GetComponent<Potion>();
            if (potion != null)
            {
                potion.ChangeColor(potionColor);
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("La potion est null");
            }
        }
    }*/
}
