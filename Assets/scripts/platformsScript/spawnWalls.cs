using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawnqube : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> blocks;

    void Start()
    {
        // spawnar walls i x och y axel (9 på y) och (5 på x)
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 9; j++)
            {
               
                Instantiate(blocks[Random.Range(0,blocks.Count)], new Vector3(j - 4, i * 1f, 0), Quaternion.identity);


            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
