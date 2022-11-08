using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
   public float speed = 5;
    public Transform groundcheck;
    public static bool isGroundet;
    public LayerMask ground;
    float jumphigh = 15;
    private Rigidbody2D rb;

    public GameObject[] caracter;
    
    public static bool gamestarts = true;

    public AudioSource jumpsound;
    float lautstärke = 1f;

    // Start is called before the first frame update
    void Start()
    {
        lautstärke = PlayerPrefs.GetFloat("Sound");

        rb = transform.GetComponent<Rigidbody2D>();
        Caracter();
    }
    public void Run()
    {
        // run
        rb.velocity = new Vector2(speed, rb.velocity.y);

        //groundcheck
        isGroundet = Physics2D.OverlapCircle(groundcheck.position, 0.5f, ground);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
        //Speed steigerung
        speed += 0.000001f;
    }

    void Update()
    {
        bool islive = !GameObject.Find("UI_Handler").GetComponent<UI_Handler>().isgameover;
        if (gamestarts && islive)
        {
            Run();
        }
        else
            rb.velocity = Vector2.zero;
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            gamestarts = true;
        }
        
    }

    public void jump() 
    { 
        if (isGroundet && gamestarts)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumphigh);
            gameObject.GetComponent<AudioSource>().volume = lautstärke;
            jumpsound.Play();
            PlayerPrefs.SetInt("jump", PlayerPrefs.GetInt("jump") + 1);
        }
        else if (!gamestarts)
        {
            gamestarts = true;
        }
    }
    public void Caracter()
    {
        int num = PlayerPrefs.GetInt("Player");

        for (int i = 0; i < caracter.Length; i++)
        {
            if (num == i)
            {
                caracter[i].SetActive(true);
            }
            else 
            { 
                caracter[i].SetActive(false);
            }
        }
    }
}
