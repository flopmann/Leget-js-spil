using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text healthText;
    void Start()
    {
        healthText.text = "health: 3";
    }
    void Update()
    {

    
        if (stormMovement.health == 2)
        {
            healthText.text = "health: 2";
        }
        if (stormMovement.health == 1) 
        {
            healthText.text = "healt: 1";
        }

    }
}
