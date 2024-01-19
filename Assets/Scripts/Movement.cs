using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float gravity = 3.71f;
    private float currentSpeed = 0;

    private CharacterController controller;
    public Animator animator;

    private Vector3 moveDirection = Vector3.zero;
    float yMovement = 0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        currentSpeed = moveSpeed;

        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(h, 0, v).normalized * currentSpeed;

        if (h != 0 || v != 0)
        {
            transform.forward = new Vector3(h, 0f, v);
        }

        yMovement -= gravity * Time.deltaTime;
        moveDirection.y = yMovement;

        controller.Move(moveDirection * Time.deltaTime);

        if (moveDirection.magnitude > 2.5)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

    }

    



}
