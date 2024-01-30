using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Storm : MonoBehaviour
{
    [SerializeField] public GameObject obj;
    [SerializeField] public float Radius = 20f;
    public GameObject target;
    private float timer = 0f;
    public float Timertilstorm = 5f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= Timertilstorm)
        {
            float angle = Random.Range(0, 360);

            float x = Mathf.Sin(angle) * Radius;
            float z = Mathf.Cos(angle) * Radius;
            float y = 2;


            Vector3 position = new Vector3(x, y, z);
            GameObject instance = GameObject.Instantiate(obj, position, Quaternion.identity);
            instance.GetComponent<stormMovement>().farm = target.transform;
                
            timer = 0f;
        }
    }
}

    

