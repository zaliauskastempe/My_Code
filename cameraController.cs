using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour
{
    public GameObject player; //brings the player object into the script so we can reference it
    private Vector3 offset; //makes a new variable 

    void Start()
    {
        offset = transform.position - player.transform.position;  //Use transform. to get the physical position, rotation, scale etc of an element.
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
