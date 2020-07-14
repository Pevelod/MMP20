using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusScript : MonoBehaviour
{

    void OnCollisionEnter2D (Collision2D colInfo)
    {
        Debug.Log(colInfo.relativeVelocity.magnitude);
    }
}
