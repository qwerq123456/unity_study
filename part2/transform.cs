using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){        //go left
            this.transform.Translate(new Vector3(-1,0,0) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.W)){        //go front
            this.transform.Translate(new Vector3(0,0,1) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)){        //go back
            this.transform.Translate(new Vector3(0,0,-1) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)){        //go right
            this.transform.Translate(new Vector3(1,0,0) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.R)){        //go up
            this.transform.Translate(new Vector3(0,1,0) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.T)){        //go down
            this.transform.Translate(new Vector3(0,-1,0) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.X)){        //x spin
            this.transform.Rotate(new Vector3(90,0,0) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.Y)){        //y spin
            this.transform.Rotate(new Vector3(0,90,0) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.Z)){        //z spin
            this.transform.Rotate(new Vector3(0,0,90) * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.C)){        //size up
            this.transform.localScale += new Vector3(1,1,1) * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.V)){        //size down
            this.transform.localScale -= new Vector3(1,1,1) * Time.deltaTime;
        }
    }
}



