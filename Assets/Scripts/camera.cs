using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform charr_;


    void FixedUpdate()
    {
        transform.position=charr_.position;        
    }
}
