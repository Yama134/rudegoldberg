using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerYAxis : MonoBehaviour
{
    public GameObject gameObject;
    public float spinRate;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.Rotate(0.0f, spinRate, 0.0f);
    }
}
