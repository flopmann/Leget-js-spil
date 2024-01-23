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

    public static int health = 3;

    

    void Update()
    {
        CloseIn();
        CheckCollisions();
    }

    private void CheckCollisions()
    {
        Collider[] cols = Physics.OverlapBox(gameObject.transform.position,transform.localScale / 2,Quaternion.identity);
        foreach (Collider col in cols)
        {
            if(col.tag == "Shield") // er det et hegn?
            {
                GameObject.Destroy(gameObject);
            }
            if (col.tag == "Farm")
            {
                health = health - 1;
                GameObject.Destroy(gameObject);
                Debug.Log(health);
                
                if (health == 0)
                {
                    SceneManager.LoadScene("loseScene");
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
