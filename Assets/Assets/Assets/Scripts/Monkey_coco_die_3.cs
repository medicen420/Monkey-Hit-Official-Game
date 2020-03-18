using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey_coco_die_3 : MonoBehaviour
{
    public GameObject Silla_normal;
    public GameObject Silla_atrapado;
    public Animator anim;
 
  
    // Start is called before the first frame update
    void Start()
    {
        //PRIMER MONKEY SILLA ATRAPADO
        Silla_atrapado.SetActive(false);
        Silla_normal.SetActive(true);
       
        GetComponent<Animator>();
     

    }

    // Update is called once per frame
    void Update()
    {
       

     
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name== "banana(Clone)")
        {
            Debug.Log("sacatlan");
            anim.SetBool("silladead", true);
            Silla_normal.SetActive(false);
            Silla_atrapado.SetActive(true);
          
        }

       

    }
  
    
    
   
   
}
