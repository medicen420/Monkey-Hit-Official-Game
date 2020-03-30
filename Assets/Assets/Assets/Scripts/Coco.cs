using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coco : MonoBehaviour
{
    public GameObject coquirri;
    public Animator anim;
    public Monkey_coco_die2 mOk;
    public int punto = 1;
    public BoxCollider bx;

    void Start()
    {
        GetComponent<Animator>();
        GetComponent<Monkey_coco_die2>();
         GetComponent<GameObject>();
    }



    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.name == "banana(Clone)")
        {
            //GameObject cocu = Instantiate(coquirri) as GameObject;

            //para manejar físicas mandamos llamar a rigidbody
            coquirri.AddComponent<Rigidbody>();
            Score.score += punto;
            Destroy(bx);
    
        }

        if(other.gameObject.tag == "arena")
        {
            anim.SetBool("coquitito", true);
            Destroy(mOk);
            Debug.Log("coco al suelo");
        }
      

        
    }


  







}
