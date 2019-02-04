using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMover : MonoBehaviour
{
    public float zSpot;
    private bool direction;
    public GameObject MovingWall;
    // Start is called before the first frame update
    void Start()
    {
        zSpot = transform.position.z;
        direction = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == true)  
        {
            Vector3 temp = new Vector3(0, 0, 0.05f);
            MovingWall.transform.position -= temp;
        }
        else
        {
            Vector3 temp = new Vector3(0, 0, 0.05f);
            MovingWall.transform.position += temp;
        }
        if (Mathf.Abs(transform.position.z) >= zSpot) direction = !direction;
    }
}
