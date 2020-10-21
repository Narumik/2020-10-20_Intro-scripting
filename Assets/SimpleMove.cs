using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public Transform target;
    public float vitesse = 1.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 deplacement = target.position - transform.position;
        deplacement = deplacement.normalized * vitesse * Time.deltaTime;
        transform.position += deplacement;
    }
}