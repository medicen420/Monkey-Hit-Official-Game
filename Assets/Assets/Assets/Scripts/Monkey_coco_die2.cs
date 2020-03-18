using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey_coco_die2 : MonoBehaviour
{
    public Animator anima;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Animator>();
       GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "coco_model (1)")
        {
            Debug.Log("me acabas de pegar con el coco");
            anim.SetBool("Dead_2", true);
        }





    }
}
