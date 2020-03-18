using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey_Icecream : MonoBehaviour
{
    
    public Animator anim;
    public Animator ani;
    


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
            
            anim.SetBool("se cae", true);
            ani.SetBool("Helado se cae", true);
           
            
            //anim.Play("Helado_cae");

        }


    }
}
