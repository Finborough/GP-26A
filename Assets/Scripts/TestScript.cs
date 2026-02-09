using System;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TestClass testclass = new TestClass();
        print(testclass.punaset);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public class TestClass
    {
        public String punaset = "ei ole puuhöylä";
    }
}
