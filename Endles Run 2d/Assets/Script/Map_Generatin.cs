using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class Map_Generatin : MonoBehaviour
{
    public GameObject[] ground;
    public List<GameObject> tilelist;
    int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        Nexttile();
        Nexttile();
       
    }

    public void DestroyLast()
    {
        Destroy(tilelist[0]);
        tilelist.RemoveAt(0);
    }
    public void Nexttile()
    {   
        int j = Random.Range(0, ground.Length);
            GameObject random = ground[j];
         tilelist.Add( Instantiate(random, new Vector2(30*i, 0),Quaternion.identity));

        i++;
    }
}
