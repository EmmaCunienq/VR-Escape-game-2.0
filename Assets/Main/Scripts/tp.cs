using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp : MonoBehaviour
{
    private int room = 1;
    public Transform player;

    void Start()
    {
        player.position = new Vector3(2.08f, 0f, 0.62f);

        room = 1;
    }

    void changeRoom()
    {
        room++;
        if (room == 2)
        {
            player.position = new Vector3(-5.5f, 0f, 1.54f);
        }
        else if (room == 3)
        {
            player.position = new Vector3(-4.92f, 0f, 10.98f);
        }
    }
}
