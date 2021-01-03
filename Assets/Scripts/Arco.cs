using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arco : MonoBehaviour
{  
    [SerializeField] GameObject arrowPrefab,shootSound;

    Manager manager;


    public float arrowForce;

    void Start()
    {
        manager=GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
    }

    
      void Update()
    {
        if(manager.start==true)
        {
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float midPoint = (transform.position-Camera.main.transform.position).magnitude*0.5f;
            transform.LookAt(mouseRay.origin + mouseRay.direction*midPoint);
            Debug.DrawRay(transform.position,transform.forward*110,Color.red);

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            Shoot();
        }
        
        }

    }

    void Shoot()
    {
        GameObject arrow = Instantiate(arrowPrefab, transform.position, transform.rotation);
        Rigidbody rb = arrow.GetComponent<Rigidbody>();
        rb.AddForce(arrow.transform.forward * arrowForce, ForceMode.Impulse);
        Instantiate(shootSound,transform.position,transform.rotation);

    }
}
