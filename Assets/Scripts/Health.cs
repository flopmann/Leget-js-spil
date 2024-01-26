using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text healthText;
    void Start()
    {
        healthText.text = "health: 100";
    }
    void Update()
    {

    
        if (stormMovement.health == 75)
        {
            healthText.text = "health: 75";
        }
        if (stormMovement.health == 50) 
        {
            healthText.text = "healt: 50";
        }
        if (stormMovement.health == 25)
        {
            healthText.text = "health: 25";
        }
    }
}
