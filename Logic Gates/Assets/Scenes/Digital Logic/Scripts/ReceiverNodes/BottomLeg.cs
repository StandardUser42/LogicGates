using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomLeg : MonoBehaviour
{
    private int n;
    public GameObject ReceiverNode2;

    // Start is called before the first frame update
    void Start()
    {
        n=0;
    }

    // Update is called once per frame
    void Update()
    {
        ReceiverNode node=ReceiverNode2.GetComponent<ReceiverNode>();

        n=node.getN();

        if(n==0)
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        else if(n==1)
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}