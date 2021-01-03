using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour
{
    [SerializeField] float timeDestroy;
    void Start()
    {
        
    }

    void Update()
    {
        Destroy(gameObject,timeDestroy);
    }
}
