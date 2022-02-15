using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beagle : Animal
{


    // Start is called before the first frame update
    void Start()
    {
        animalRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Run();
    }
}
