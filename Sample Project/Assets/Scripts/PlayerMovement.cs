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
    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F; 
    void Update()
    {
        float move = Input.GetAxis ("Vertical");
        anim.SetFloat("Speed", move);

        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
       
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(0, 0, -(speed * Time.deltaTime));
            
        }
        
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(-(speed * Time.deltaTime), 0, 0);
            
        }
        
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate((speed * Time.deltaTime), 0, 0);
            
        }
        
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
         float v = verticalSpeed * Input.GetAxis("Mouse Y");
         transform.Rotate(v, h, 0);
    }
}
