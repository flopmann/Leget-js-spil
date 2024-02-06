using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class farmHitSound : MonoBehaviour
{
    public AudioSource audio_src3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hitSound();
    }

    public void PlaySound()
    {
        audio_src3.Play();
        Debug.Log("crash");
    }

    void hitSound()
    {
        Collider[] cols = Physics.OverlapBox(transform.position, transform.localScale / 2, Quaternion.identity);

        foreach (Collider col in cols)
        {
            Debug.Log(col.tag);
            if (col.tag == "Storm")
            {
                audio_src3.Play();
                Debug.Log("crash");
            }
        }

    }

}
