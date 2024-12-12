using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movmentwalls : MonoBehaviour
{
    public float movmentspeed; 
    Rigidbody2D rigitbody; 
    // Start is called before the first frame update
    void Start()
    {
       rigitbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigitbody.velocity = new Vector2(0.3f * movmentspeed, 0);
    }
}
