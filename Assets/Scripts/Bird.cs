using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    private Rigidbody rigidbody;
    private float alt;
    private bool gameOver = false;
    public GameObject cauda;
    private float lastAlt;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        alt = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        int interval = 1;
        interval--;
        
        bool jump = Input.GetKeyDown(KeyCode.Space); 
        if(interval <= 0 && jump && !gameOver)
        {
              
            rigidbody.AddForce(new Vector3(0,10,0), ForceMode.Impulse);
            //gameObject.transform.rotation = Quaternion.Euler(0,0,90);
            interval = 1;

        
            
        }
        if(rigidbody.velocity.y >= 0){
            gameObject.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0, 60), Time.deltaTime * 10);            
        }else{
            gameObject.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,-90), Time.deltaTime * 2);            
        }
        
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Cano")){
            var colider = gameObject.GetComponent<BoxCollider>();
            colider.isTrigger = true;
            gameOver =true;
            Debug.Log("game over");
        }
    }
}
