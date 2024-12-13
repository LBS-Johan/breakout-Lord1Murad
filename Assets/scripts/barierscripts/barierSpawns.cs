using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barierSpawns : MonoBehaviour
{
    public GameObject barier;
    // Start is called before the first frame update
    void Start()
    {
        Quaternion rotation = Quaternion.Euler(0, 0, 90);
        // left side barier spawn
        for (int i = 0; i < 10; i++)
        Instantiate(barier, new Vector3(-8.5f, i - 4.5f, 0), Quaternion.identity);
        //right side barier spawn
        for (int i = 0; i < 10; i++)
        Instantiate(barier, new Vector3(8.5f, i - 4.5f, 0), Quaternion.identity);
        //ipp side barier spawn
        for (int i = 0; i < 16; i++)
        Instantiate(barier, new Vector3(i - 7.5f,-4.5f, 0), rotation);
        //down side barier spawn
        for (int i = 0; i < 16; i++)
        Instantiate(barier, new Vector3(i - 7.5f, 4.8f, 0), rotation);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
