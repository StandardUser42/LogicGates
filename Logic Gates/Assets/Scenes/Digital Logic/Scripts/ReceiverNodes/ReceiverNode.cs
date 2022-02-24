using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiverNode : MonoBehaviour
{
    private int n;

    // Start is called before the first frame update
    void Start()
    {
        n=0;
    }

    // Update is called once per frame
     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("One"))
        {
            n=1;
        }
        else
        {
            n=0;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("One"))
        {
            n=1;
            Debug.Log("Triggered");
        }
        else
        {
            n=0;
        }
    }

    void OnTriggerExit(Collider other)
    {
        n=0;
        Debug.Log("Trigger Exit");
    }

    public int getN()
    {
        return n;
    }
}