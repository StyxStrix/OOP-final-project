using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pug : Animal
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

    public override void Run()
    {
        forwardInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
        // Move the car forward
        animalRb.AddRelativeForce(Vector3.forward * turnInput * speed);
        //Turing the car (not limited to while moving - for now)
        transform.Rotate(Vector3.up * Time.deltaTime * agility *forwardInput);
    }
}
