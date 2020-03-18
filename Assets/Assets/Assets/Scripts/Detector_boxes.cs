using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector_boxes : MonoBehaviour
{
    public Animator anims;
    public GameObject mono;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>();

    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag== "barril")
        {
            anims.SetBool("fall", true);
            //mono.AddComponent<Rigidbody>();
            //mono.AddComponent<BoxCollider>();
            Debug.Log("me acaba de pegar un barril de madera");
            
        }
    }
}
