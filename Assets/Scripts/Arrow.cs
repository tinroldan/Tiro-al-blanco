using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Vector3 hitPosition;
    [SerializeField] GameObject hitSoud;
    void Update()
    {
        Destroy(gameObject,3f);
    }

    private void OnTriggerEnter ( Collider other) {

        if(other.tag=="escenario")
        {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.isKinematic=true;
        Instantiate(hitSoud,transform.position,transform.rotation);


        }
    }
}


