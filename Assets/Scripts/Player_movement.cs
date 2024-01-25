using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player_movement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float verticalSpeed;

    [SerializeField]
    private CharacterController characterController;

    [SerializeField]
    private Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        moveDirection = Vector3.zero;

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 forward = transform.forward * y;
        Vector3 right = transform.right * x;

        moveDirection = forward + right;

        moveDirection.Normalize();

        moveDirection.y = verticalSpeed;

        characterController.Move(moveDirection*speed*Time.deltaTime);
    }
}
