using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PetManager : MonoBehaviour
{
    public PetController pet;
    public NeedsController needsController;
    public float petMovetimer, originalpetMovetimer;
    public Transform[] Waypoints;
    
    public static PetManager instance;
    
    // Start is called before the first frame update
    private void Awake()
    {
        originalpetMovetimer = petMovetimer;
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More than one PetManager in the Scene");
    }

    private void Update()
    {
        if (petMovetimer > 0)
        {
            petMovetimer -= Time.deltaTime;
        }
        else
        {
            MovePetToRandomWaypoint();
            petMovetimer = originalpetMovetimer;
        }
    }

    private void MovePetToRandomWaypoint()
    {
        int randomWaypoint = Random.Range(0, Waypoints.Length);
        pet.Move(Waypoints[randomWaypoint].position);
        
    }

    public void Die()
    {
        Debug.Log("Dead");
    }
}
