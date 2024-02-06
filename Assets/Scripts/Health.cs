using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{   
    public Text healthText;

    void Start()
    {
        stormMovement.health = 100;
    }
    void Update()
    {
        stormMovement.health.ToString();
        healthText.text = stormMovement.health.ToString();
    }
}
