using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    [Tooltip("Object to follow")]
    public Transform follow;
    [Tooltip("Max speed")]
    public float speed;

    private Vector3 offSet;
    private Vector3 target;
    private float currentSpeed = 0f;


     void Start()
    {
        offSet = transform.position - follow.position;
    }

    void Update()
    {
        Follow();   
    }

    private void Follow()
    {
        target = follow.position + offSet;


        float distance = (target - transform.position).magnitude;

        currentSpeed = speed;


        Vector3 newPosition = Vector3.MoveTowards(transform.position, target, currentSpeed * Time.deltaTime);
        transform.position = newPosition;
        
    }

}
