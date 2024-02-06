using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FarmRotation : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;

    public AudioSource audio_src2;

    public static int carrotsFarmed;


    void Start()
    {
        carrotsFarmed = 0;
    }

    void Update()
    {
        transform.Rotate(_rotation * Time.deltaTime);
        
    }
    void OnTriggerEnter(Collider other)
    {
        carrotsFarmed = carrotsFarmed + 1;
        //Debug.Log(carrotsFarmed);

        if (carrotsFarmed == 1000)
        {
            SceneManager.LoadScene("AltWinScene");
            carrotsFarmed = 0;
            //health = 100;

            audio_src2.Play();
            Debug.Log("yippie");
        }
    }
}
