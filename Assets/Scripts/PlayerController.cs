using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {

       playerRb = GetComponent<Rigidbody>();
       
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Impulse, It's a force mode which applies inmediatly
            playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }
}
