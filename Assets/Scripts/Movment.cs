using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(Time.deltaTime * speed,0,0);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(Time.deltaTime * -speed,0,0);
        }
    }
}
