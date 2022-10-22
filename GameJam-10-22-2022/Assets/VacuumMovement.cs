using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacuumMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float RotationSpeed;
    private Quaternion lookRotation;
    private Vector3 direction;

    void Start()
    {
        //cube = GameObject.FindWithTag("Player");
     //   center = cube.transform;
      //  transform.position = (transform.position - center.position).normalized * radius + center.position;
    }

    // Update is called once per frame
    void Update()
    {
        //mouse = Input.mousePosition;
        //castPoint = Camera.main.ScreenPointToRay(mouse);
        ////I'm not sure if castPoint has a position in it or not, but if when you type castPoint.transform.position
        //direction = (castPoint.- transform.position).normalized;

        ////create the rotation we need to be in to look at the target
        //lookRotation = Quaternion.LookRotation(direction);

        ////rotate us over time according to speed until we are in the required rotation
        //transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * RotationSpeed);
    
    }
}
