using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_ : MonoBehaviour
{
    public GameObject charr_;
    public float scale_;
    
    void Start()
    { 
        transform.localScale*=scale_; 
    }

    void FixedUpdate()
    { 
        transform.position= new Vector3(charr_.transform.position.x,transform.position.y,charr_.transform.position.z+transform.localScale.z/2+5.2f); 
    }






}
