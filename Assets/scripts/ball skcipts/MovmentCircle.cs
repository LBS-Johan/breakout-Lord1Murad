using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovmentCircle : MonoBehaviour
{
    public int speed = 1; 
    Rigidbody2D rigitbodyCircle;
    // Start is called before the first frame update
    void Start()
    {
        rigitbodyCircle = GetComponent<Rigidbody2D>();
        rigitbodyCircle.velocity = new Vector2(0, -4);
    }

    // Update is called once per frame
    void Update()
    {
        
       float speed = 4;
       rigitbodyCircle.velocity = rigitbodyCircle.velocity.normalized * speed;
        

    }
    
    
}
