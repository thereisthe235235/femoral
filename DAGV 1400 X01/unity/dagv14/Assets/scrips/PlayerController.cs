using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float sprintspeed = 10.0f;
    public float crouchspeed = 2.5f;
    private float horizontalInput;
    private float forwardInput;
    private bool crouch = false;

    public float jumpForce = 5.0f;
    private Rigidbody playerRb;


    // Start is called before the first frame update
    void Start()
    {
        crouch = false;
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

// here is where i set up the sprint. No matter what i press the charecter will use the speed verible//
// i just change the speed to be the sprint speed verible vaule, and then reset it when the shift key is no longer being pressed.//


        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = sprintspeed;
        }
        else
        {
            speed = speed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5.0f;
        }

//here is where i created the crouch ablity. first we define what happens when the bool vaule of crouch vaule is true//
// then I set the left control to set the crouuch value when held down. and then resets the vaules to its orginal when they let go of it.//
//ives set crouch to change speed, jumpforce, and the scale of y. i made him slower, made the jump force 0 so there is no jump, and made him a little shofter.//

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            crouch = true;
        }

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            crouch = false;
            speed = 5.0f;
            transform.localScale = new Vector3(1, 1, 1);
            jumpForce = 5.0f;
        }
        if (crouch == true)
        {
            speed = crouchspeed;
            transform.localScale = new Vector3(1, .5f, 1);
            jumpForce = 0;
        }
        else
        {
            speed = speed;
        }




    }
}
