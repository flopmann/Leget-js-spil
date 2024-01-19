using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stormMovement : MonoBehaviour
{
    public Transform farm;
    public float speed;
    private Vector3 target;

    private float currentSpeed = 0f;

    void Update()
    {
        CloseIn();
    }


    private void CloseIn()
    {
        target = farm.position;


        float distance = (target - transform.position).magnitude; 

        currentSpeed = speed;

        Vector3 newPosition = Vector3.MoveTowards(transform.position, target, currentSpeed * Time.deltaTime);
        transform.position = newPosition;
    }
}
