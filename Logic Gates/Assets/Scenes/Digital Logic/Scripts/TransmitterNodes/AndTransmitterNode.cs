using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndTransmitterNode : MonoBehaviour
{
    private int n;
    public GameObject ReceiverNode1;
    public GameObject ReceiverNode2;

    // Start is called before the first frame update
    void Start()
    {
        n=0;
    }

    // Update is called once per frame
    void Update()
    {
        //Calls the scripts
        ReceiverNode node1=ReceiverNode1.GetComponent<ReceiverNode>();
        ReceiverNode node2=ReceiverNode2.GetComponent<ReceiverNode>();

        //Assigns and computes the gate logic
        int n1=node1.getN();
        int n2=node2.getN();

        n=n1&n2;

        if (n==1)
        {
            gameObject.tag="One";
        }
        else
        {
            gameObject.tag="Untagged";
        }
        //GetComponent<Renderer>().material.color = Color.blue;
    }

    public int getN()
    {
        return this.n;
    }
}
