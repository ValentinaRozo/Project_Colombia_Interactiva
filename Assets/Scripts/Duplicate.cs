using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Utilities;

public class Duplicate : MonoBehaviour
{
    public GameObject Fauna_flora;
    //GestureRecognizer recognizer = new GestureRecognizer();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clone()
    {
        Instantiate(gameObject, Fauna_flora.transform, true);
    }

}
