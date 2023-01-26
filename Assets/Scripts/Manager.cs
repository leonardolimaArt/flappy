using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public int time = 2;
    public GameObject cano;
    void Start()
    {
        InvokeRepeating("Inst", 0, 2f);
    }

    // Update is called once per frame
    void Inst()
    {

        Instantiate(cano, new Vector3(transform.position.x, Random.Range(-3.5f, 3f), transform.position.z) , Quaternion.identity);


    }
}
