using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey_Salvavidas : MonoBehaviour
{
    public Animator anim;
    


    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Animator>();
        anim.Play("nadando_salvavidas");
       // anim.Play("Idle_salvavidas");



    }

    // Update is called once per frame
    void Update()
    {



    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "banana(Clone)")
        {
          Debug.Log("mia kalifa");

        }


    }
}
