using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FarmRotation : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;

    public float carrotsFarmed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotation * Time.deltaTime);
        
    }
    void OnTriggerEnter(Collider other)
    {
        carrotsFarmed = carrotsFarmed + 1;
        Debug.Log(carrotsFarmed);

        if (carrotsFarmed == 30000)
        {
            SceneManager.LoadScene("winScene");
        }
    }
}
