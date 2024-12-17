using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject healthUi;
    public GameObject cirkel;
    public int maxHealth = 3;
    int currentHealth;
    Rigidbody2D rigitbody;
    // Start is called before the first frame update
    void Start()
    {
        rigitbody = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rigitbody.position.x <-10 || rigitbody.position.x >10 || rigitbody.position.y >6 || rigitbody.position.y <-6)
        {
            rigitbody.position = new Vector2(0, -1);
            currentHealth -= 1;
            Destroy (healthUi.transform.GetChild(currentHealth).gameObject);
             
        }
        if (currentHealth  == 0)
        {
            Destroy(cirkel);
            //lossing scene 
            SceneManager.LoadScene(1);
        }
    }
    
  
}
