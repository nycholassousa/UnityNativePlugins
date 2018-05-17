using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class TestDLL : MonoBehaviour
{
    // The imported function
    [DllImport("TestSortDLL", EntryPoint = "TestSort")]
    public static extern void TestSort(int[] a, int length);
    static bool needLogs = false;

    public static void PrintLog(string logMessage)
    {
        if (needLogs)
            Debug.Log(logMessage);
        // or you can use like 
        #if UNITY_EDITOR
            Debug.Log(logMessage);
        #endif
    }

    int[] a = { 10, 2, 5, 1, 0 };

    void Start()
    {
        print("Array Unsorted: ");
        foreach (var item in a)
            print(item.ToString());

        TestSort(a, a.Length);

        print("Array Sorted: ");
        foreach (var item in a)
            print(item.ToString());
    }
}
