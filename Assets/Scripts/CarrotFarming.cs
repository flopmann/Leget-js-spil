using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotFarming : MonoBehaviour
{
    [SerializeField]
    GameObject Carrot;
    
    //public Vector3 moveDirection;
    public AudioSource audio_src1;

    void OnTriggerEnter(Collider other)
    {
        //Carrot.transform.position += moveDirection;

        Vector3 position = transform.position;
        position.y = -0.5f;
        transform.position = position;
        

        audio_src1.pitch = Random.Range(0.5f, 1.5f);
        audio_src1.Play();

        

    }

}


