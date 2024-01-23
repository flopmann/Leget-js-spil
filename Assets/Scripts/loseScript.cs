using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseScript : MonoBehaviour
{
    public float health = 3;
    void Update()
    {
        Collider[] cols = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 2, Quaternion.identity);
        foreach (Collider col in cols)
        {
            if (col.tag == "Storm")
            {
                health = health - 1;
                GameObject.Destroy(gameObject);
                Debug.Log(health);
            }
        }



    }
}
