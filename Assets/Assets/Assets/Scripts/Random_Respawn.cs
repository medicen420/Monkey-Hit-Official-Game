using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Respawn : MonoBehaviour
{
    public GameObject monkeys;
    public GameObject[] monkeysList;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        monkeysList = GameObject.FindGameObjectsWithTag("Enemy");
        if (monkeysList.Length == 0) MonkeySpawn();
        Debug.Log(monkeysList.Length);
    }

    public void MonkeySpawn()
    {
        for (int i = 0; i <2; i++)
        {
            // poner valores de tranforms en esta parte 
            //                                          x                               y                                 z  
            Vector3 randomSpawn = new Vector3(Random.Range(-0.31f, 9.04f), Random.Range(-0.401f, -0.40f), Random.Range(-18.35f, -18.35f));
            Instantiate(monkeys, randomSpawn, transform.rotation);
        }
    }
}
