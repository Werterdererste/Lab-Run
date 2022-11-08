using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 9)
        {
            GameObject.Find("mapgenaretor").GetComponent<Map_Generatin>().Nexttile();
             GameObject.Find("mapgenaretor").GetComponent<Map_Generatin>().DestroyLast();

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
