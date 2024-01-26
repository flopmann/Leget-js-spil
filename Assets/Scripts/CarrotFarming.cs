using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotFarming : MonoBehaviour
{
    [SerializeField]
    GameObject Carrot;

    
    public Vector3 moveDirection;
    public AudioSource audio_src1;

    void OnTriggerEnter(Collider other)
    {
        Carrot.transform.position += moveDirection;

        audio_src1.Play();

        

    }

}


