using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;
    //public Animator animator;
    float horizontal;
    float vertical;

    public float runSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        //if (horizontal == 0 && vertical == 0)
        //{
        //    animator.SetBool("stand", true);
        //}
        //else {
        //    animator.SetBool("stand", false);
        //}
        ////
        //if (horizontal < 0 && vertical > 0)
        //{
        //    animator.SetBool("ul", true);
        //}
        //else
        //{
        //    animator.SetBool("ul", false);
        //}
        ////
        //if (horizontal > 0 && vertical > 0)
        //{
        //    animator.SetBool("ur", true);
        //}
        //else
        //{
        //    animator.SetBool("ur", false);
        //}
        ////
        //if (horizontal > 0 && vertical < 0)
        //{
        //    animator.SetBool("dr", true);
        //}
        //else
        //{
        //    animator.SetBool("dr", false);
        //}
        ////
        //if (horizontal < 0 && vertical < 0)
        //{
        //    animator.SetBool("dl", true);
        //}
        //else
        //{
        //    animator.SetBool("dl", false);
        //}
   


        //animator.SetFloat("dir_h", horizontal);
        //animator.SetFloat("dir_v", vertical);
        
        
        // initially, the temporary vector should equal the player's position
        Vector3 clampedPosition = transform.position;
        // Now we can manipulte it to clamp the y element (i x)
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, -4.5f, 4.5f);
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -5f, 5f);
        // re-assigning the transform's position will clamp it
        transform.position = clampedPosition;
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed).normalized*runSpeed;
    }
}
