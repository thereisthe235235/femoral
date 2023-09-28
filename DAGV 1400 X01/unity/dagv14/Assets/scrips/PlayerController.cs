using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float moveSpeed = .1f;
    private float jumpForce = 5f;
    private float gravity = 9.81f;

    private CharacterController controller;

    private float ForwardInput;
    private float HorzionInput;
    private bool isJumping;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
   
        HorzionInput = Input.GetAxis("Horizontal");
        ForwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * ForwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * HorzionInput);

    }
}
