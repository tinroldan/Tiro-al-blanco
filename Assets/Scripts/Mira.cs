using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mira : MonoBehaviour
{
    Manager manager;


    float cameraDistance = 10f;

    Ray ray;
    void Start()
    {
        manager=GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        
    }

    void Update()
    {
        if(manager.start==true)
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            transform.position=ray.GetPoint(cameraDistance);
            Debug.DrawRay(ray.origin,ray.direction*100,Color.green);

        }
        

        

        
    }

    
}
