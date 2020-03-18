using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
    private Touch touch;
    private Vector3 touchPosition;
    private Quaternion rotationX;
    private float rotateSpeedModifier = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                rotationX = Quaternion.Euler(-touch.deltaPosition.y * rotateSpeedModifier, 0f, 0f);

                transform.rotation = rotationX * transform.rotation;
            }
        }
    }
}
