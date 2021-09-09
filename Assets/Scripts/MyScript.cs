using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    int n;
    void Start()
    {
        for (int i = 1; i <= 100; i++) 
        {
            print(i);
        }
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
                print(i);
        }
        float x = 1.0f;
        float r = circle(x);
        //print(r);


    }
     float circle(float x)
    {
        float result;
        x = 5.0f;
        result = 3.14f * (x*x) ;
        print(result);
        return result;
    }

}