using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signal : MonoBehaviour
{
    private float createdTime;

    // Start is called before the first frame update
    void Start()
    {
        createdTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = (Time.time - createdTime) * Vector3.one;
    }
}
