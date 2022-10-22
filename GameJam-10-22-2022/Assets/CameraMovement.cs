using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform targetToFollow;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, -5.5f, 5.5f), Mathf.Clamp(targetToFollow.position.y, -3.0f, 3.0f), transform.position.z);
    }
}
