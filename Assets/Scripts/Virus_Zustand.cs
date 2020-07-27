using UnityEngine;
using System.Collections;

public class Virus_Zustand : MonoBehaviour
{

    //VirusScript virusScript = GameObject.FindGameObjectWithTag("Virus").GetComponent<VirusScript>();
    // Update is called once per frame

    void Start()
    {
       // VirusScript virusScript = GameObject.FindGameObjectWithTag("Virus").GetComponent<VirusScript>();
    }

    void Update()
    {
        Debug.Log(GameObject.FindGameObjectWithTag("Virus") == null);
       
        
        
    }


}