using UnityEngine;

public class Barril : MonoBehaviour
{
    public static int puntos = 1;
    float currentime = 0;
    float maxTime = 1.5f;
    public Animator anim;
    public Animator anima;
    public GameObject idle;
    public GameObject fall;
    public GameObject bx;
    bool monedita;

    //public Animator anima;
    bool fresa;

    //public GameObject piso;

    void Start()
    {
        //anima = GetComponent<Animator>();
        anim = GetComponent<Animator>();
        anima = GetComponent<Animator>();
        monedita = false;

     


        //piso.SetActive(true);

    }



    //Cuando mi proyectil o la banana impacte con el barril... 
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "banana(Clone)")
        {
            //Debug.Log("hola banana");
            anim.SetBool("caida", true);
            //variable booleana que nos ayudará a controlar el current time dentro de Update

            fresa = true;
            


        }
    }


    void Update()
    {
        if (fresa == true)
        {

            Debug.Log("fresa esta activada");
            currentime += Time.deltaTime;

            if (currentime >= maxTime)
            {
                //Destroy(piso);
                //currentime = 0;

                idle.SetActive(false);
                fall.SetActive(true);
                bx.SetActive(false);
                anima.SetBool("fall", true);

                //variable que nos ayudará a activar el puntaje
                monedita = true;

                Debug.Log("ya esta");
            }

        }


    }


 




}









