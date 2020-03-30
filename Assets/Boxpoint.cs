using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxpoint : MonoBehaviour
{
    //Score.score += puntos;
    public int punto = 1;
    public BoxCollider bx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name== "banana(Clone)")
        {
            Score.score += punto;
            Destroy(bx);
        }
    }
}
