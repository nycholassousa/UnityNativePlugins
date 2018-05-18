using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class RandomNumber : MonoBehaviour
{

    [DllImport("BaseSample")]
    private static extern int GetRandom();

    // Use this for initialization
    void Start()
    {
        print("Native Random Number: " + GetRandom());
        print("Funcionou.");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
