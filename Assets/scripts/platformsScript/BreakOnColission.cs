using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BreakOnColission : MonoBehaviour
{
    public GameObject wall; 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);  
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
