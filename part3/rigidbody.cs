using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbody : MonoBehaviour
{
    private Rigidbody myRigid;
    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            myRigid.velocity = Vector3.forward;
        }
        if(Input.GetKey(KeyCode.A)){
            myRigid.maxAngularVelocity = 1000;
            myRigid.AddTorque(Vector3.up);
        }
        if(Input.GetKey(KeyCode.S)){
            myRigid.AddExplosionForce(10, -this.transform.forward, 10);
        }
        if(Input.GetKey(KeyCode.D)){
            myRigid.MovePosition(-Vector3.forward);
        }
    }
}
