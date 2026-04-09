using System;
using Unity.VisualScripting;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public Player player;


    public int[] numbers = new int[10]; 
    public int numberObjectCount = 0;
   
    void Start()
    {
        int currentNumber = 0;
        //  Loop through Array
        foreach (int number in numbers){
            // If fewer GameObjects than items in Array, break loop
            if (GameObject.Find(currentNumber.ToString()) == null)
            {
                break;
            }
        // If GameObject matches number, print the found GameObject
       // print(GameObject.Find(currentNumber.ToString()));
        currentNumber += 1;
        numberObjectCount += 1;
        }
        print(numberObjectCount.ToString() + " number objects");
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

