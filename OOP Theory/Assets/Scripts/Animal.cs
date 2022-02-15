using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public Rigidbody animalRb;
    [SerializeField] protected int strength = 100;
    [SerializeField] protected int speed = 5;
    [SerializeField] protected int agility = 100;
    [SerializeField] protected float forwardInput;
    [SerializeField] protected float turnInput;


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


    protected void Jump(float force)
    {
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animalRb.AddForce(Vector3.up * strength * force);
            }
        }
    }

    protected void Jump()
    {
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animalRb.AddForce(Vector3.up * strength);
            }
        }
    }

    public virtual void Run()
    {
        forwardInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
        // Move the animal forward
        animalRb.AddRelativeForce(Vector3.forward * forwardInput * speed);
        //Turing the animal
        transform.Rotate(Vector3.up * Time.deltaTime * agility * turnInput);
    }
}