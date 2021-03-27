using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    private BoxCollider col;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitinfo;
            if(col.Raycast(ray, out hitinfo, 1000)){
                this.transform.position = hitinfo.point;
            }
        }
    }
    private void OnTriggerStay(Collider other) {
        other.transform.position += new Vector3(0, 0, 0.01f);
    }
    private void OnTriggerExit(Collider other) {
        other.transform.position += new Vector3(0, 2, 0);
    }
    private void OnCollisionEnter(Collision other) {
        this.transform.position += new Vector3(0,2,0);
    }
}