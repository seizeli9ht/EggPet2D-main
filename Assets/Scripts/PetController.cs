using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetController : MonoBehaviour
{
    public Animator petAnimator;
    public Vector3 destination;
    public float speed;
    void Awake()
    {

    }

    private void Updata()
    {
        if (Vector3.Distance(transform.position, destination) > 0.5f)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination,speed*Time.deltaTime);
        }
    }
    
    public void Move(Vector3 destination)
    {
        this.destination = destination;
    }
    public void Happy()
    {
        petAnimator.SetTrigger("Happy");
    }
    public void Hungry()
    {
        petAnimator.SetTrigger("Hungry");
    }
    public void Sad()
    {
        petAnimator.SetTrigger("Sad");
    }
    public void Tired()
    {
        petAnimator.SetTrigger("Tired");
    }
    public void Eat()
    {
        petAnimator.SetTrigger("Eat");
    }
}
