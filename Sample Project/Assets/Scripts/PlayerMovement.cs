using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
Animator anim;

    // Update is called once per frame
    
    void Start () 
    {
        anim = GetComponent<Animator>();
    }
    public float speed; 
    void Update()
    {
        float move = Input.GetAxis ("Vertical");
        anim.SetFloat("Speed", move);

        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(0, 0, speed * Time.deltaTime);
            
        }
        
       
        
    }
}
