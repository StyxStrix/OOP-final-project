using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody animalRb;
    public int strength;


    // Start is called before the first frame update
    void Start()
    {
        animalRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animalRb.AddForce(Vector3.up * strength);
        }
    }
}
