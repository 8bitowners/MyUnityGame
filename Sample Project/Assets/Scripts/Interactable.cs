using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{


public string description = "Description";

public bool inReach;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Reach") 
        {
            inReach = true; 
           
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Reach") {
            inReach = false;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (inReach && Input.GetKey(KeyCode.E)) {
            
        }
    }
}
