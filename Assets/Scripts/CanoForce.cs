using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoForce : MonoBehaviour
{

    private float force = -3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
        transform.position += new Vector3(force * Time.deltaTime,0,0);
    }
}
