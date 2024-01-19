using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotFarming : MonoBehaviour
{
    [SerializeField]
    GameObject Carrot;

    public Vector3 moveDirection;

    void OnTriggerEnter(Collider other)
    {

        Carrot.transform.position += moveDirection;
    }

}


