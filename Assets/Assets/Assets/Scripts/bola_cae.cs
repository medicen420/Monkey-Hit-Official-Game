using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola_cae : MonoBehaviour
{
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {



    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "banana(Clone)")
        {

            //Debug.Log("mamame el huevo");


            anim.SetBool("Bolita", true);

        }


    }
}
