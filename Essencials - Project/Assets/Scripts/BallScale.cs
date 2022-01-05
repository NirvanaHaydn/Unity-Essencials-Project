using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScale : MonoBehaviour
{
    public Vector3 scaleChange;
    public Vector3 positionChange;
    void Start()
    {
        transform.localScale += scaleChange;
        transform.position += positionChange;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localScale += scaleChange;
        //transform.localPosition += positionChange;
    }
}
