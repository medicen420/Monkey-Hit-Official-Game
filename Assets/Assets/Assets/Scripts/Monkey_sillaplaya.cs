using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey_sillaplaya : MonoBehaviour
{
    public GameObject monkey_silla_idle;
    public GameObject monkey_silla_dead;
    public int punto = 1;
    public BoxCollider bx;

    // Start is called before the first frame update
    void Start()
    {
        monkey_silla_idle.SetActive(true);
        monkey_silla_dead.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "banana(Clone)")
        {
            Debug.Log("la silla me aplasto");
            monkey_silla_idle.SetActive(false);
            monkey_silla_dead.SetActive(true);
            Score.score += punto;
            Destroy(bx);
        }
    }


}
