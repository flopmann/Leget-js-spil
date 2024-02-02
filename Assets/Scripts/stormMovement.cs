using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class stormMovement : MonoBehaviour
{
    public Transform farm;
    public float speed;
    private Vector3 target;
    
    private float currentSpeed = 0f;

    public static int health = 100;

    public static int carrotsFarmed = carrotsFarmed;

    //private new SphereCollider collider;

    private void Start()
    {
        //collider = GetComponent<SphereCollider>();
    }
    void Update()
    {
        CloseIn();
        CheckCollisions();
    }

    private void CheckCollisions()
    {
        Collider[] cols = Physics.OverlapBox(gameObject.transform.position,transform.localScale / 2,Quaternion.identity);
        //Collider[] cols = Physics.OverlapSphere(gameObject.transform.position, collider.radius);
        foreach (Collider col in cols)
        {
            if(col.tag == "Shield") // er det et hegn?
            {
                GameObject.Destroy(gameObject);
            }
            if (col.tag == "Farm")
            {
                health = health - 25;
                GameObject.Destroy(gameObject);
                
                
                if (health == 0)
                {
                    SceneManager.LoadScene("AltLoseScene");
                    carrotsFarmed = 0;
                    health = health + 100;
                }
            }
        }
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
