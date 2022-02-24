using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Generate_Input : MonoBehaviour
{
    public GameObject input;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            Instantiate(input, new Vector3(0,0,0), Quaternion.identity);
        }
    }
}