using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Transform Player;
    public float pos = 5;

    void Update()
    {
        transform.position = new Vector3(Player.position.x + pos, 0,-10);
    }
}
