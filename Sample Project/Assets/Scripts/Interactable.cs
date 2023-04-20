using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{


public string description = "Description";

public bool inReach;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    void OnTriggerEnter(Collider other) {
        inReach = true;
    }

    void OnTriggerExit(Collider other) {
        
            inReach = false;
            
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inReach && Input.GetKey(KeyCode.E)) {
            SceneManager.LoadScene("SecondaryScene");
        }
    }
}
