using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana : MonoBehaviour
{
    Manager manager;
    string sideX,sideY;
    [SerializeField] float speedDiana;

    [SerializeField] GameObject soundDiana,pointsAnim;


    void Start()
    {
        manager=GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        sideX="left";
        sideY="up";

        
        
    }

    void Update()
    {
        if(manager.start==true)
        {

        //move X

        if(transform.position.x<20&&sideX=="right")
        {
            transform.position = new Vector3(transform.position.x+(speedDiana*Time.deltaTime),transform.position.y,transform.position.z);

        }
        else if(transform.position.x>=20)
        {
            sideX="left";
        }

        if(transform.position.x>-20&&sideX=="left")
        {
            transform.position = new Vector3(transform.position.x-(speedDiana*Time.deltaTime),transform.position.y,transform.position.z);

        }
        else if(transform.position.x<=-20)
        {
            sideX="right";
        
        }

        //move Y

        if(transform.position.y<35&&sideY=="up")
        {
            transform.position = new Vector3(transform.position.x,transform.position.y+(speedDiana*Time.deltaTime),transform.position.z);

        }
        else if(transform.position.y>=35)
        {
            sideY="down";
        }

        if(transform.position.y>6&&sideY=="down")
        {
            transform.position = new Vector3(transform.position.x,transform.position.y-(speedDiana*Time.deltaTime),transform.position.z);

        }
        else if(transform.position.y<=6)
        {
            sideY="up";
        }





        }
        
        
    }


    private void OnTriggerEnter ( Collider other) {

        if(other.tag=="flecha")
        {

        
        Destroy(other.gameObject);
        manager.SetPoints(10);
        transform.localScale = new Vector3(transform.localScale.x+3,transform.localScale.y+3,transform.localScale.z);
        Instantiate(soundDiana,transform.position,transform.rotation);
        Instantiate(pointsAnim,transform.position,transform.rotation);
        Destroy(gameObject,0.05f);


        }
    }
}
