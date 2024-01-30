using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carrotsFarmed : MonoBehaviour
{
    public Text carrotsFarmedText;
    void Update()
    {

        carrotsFarmedText.text = FarmRotation.carrotsFarmed.ToString();
    }
}
