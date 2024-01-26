using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotFarming : MonoBehaviour
{
    [SerializeField]
    GameObject Carrot;

    public float carrotsFarmed;
    public Vector3 moveDirection;
    public AudioSource audio_src1;

    void OnTriggerEnter(Collider other)
    {
        Carrot.transform.position += moveDirection;

        audio_src1.Play();

        carrotsFarmed = carrotsFarmed + 1;
        Debug.Log(carrotsFarmed);

    }

}


