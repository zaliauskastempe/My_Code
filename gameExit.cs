using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameExit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape")) //taken straight from the page for application.quit
        {
            Application.Quit();
        }
    }
}
