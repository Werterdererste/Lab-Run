using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animationen : MonoBehaviour
{
    public Animator caracter;

    public bool isGroundet;

    int i = 0;
    public void Update()
    {
        isGroundet = playerMovement.isGroundet;
        if (i == 0)
        {
            Gamestart();
        }
        else
            Jump();

        Dead();
    }
    public void Gamestart()
    {
        if (playerMovement.gamestarts)
        {
            caracter.SetBool("isstart", true);
            i++;
        }
    }
    public void Jump()
    {
        // animation
        if (isGroundet)
        {
            caracter.SetBool("isjump", false);

        }
        else
        {
            caracter.SetBool("isjump", true);

        }
    }
    public void Dead()
    {
        if (GameObject.Find("UI_Handler").GetComponent<UI_Handler>().isgameover)
        {
            caracter.SetBool("isgameover", true);
        }
    }
}

