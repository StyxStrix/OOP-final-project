using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doberman : Animal
{
    protected new int speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        animalRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump(2);
        Run();
    }
}