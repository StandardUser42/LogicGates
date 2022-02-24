using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndNose : MonoBehaviour
{
    private int n;
    public GameObject TransmitterNode;

    // Start is called before the first frame update
    void Start()
    {
        n=0;
    }

    // Update is called once per frame
    void Update()
    {
        AndTransmitterNode node=TransmitterNode.GetComponent<AndTransmitterNode>();

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