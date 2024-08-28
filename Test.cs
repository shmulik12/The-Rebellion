using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
int x;
    // Start is called before the first frame update
    void Start()
    {
      x = 1;  
    }

    // Update is called once per frame
    void Update()
    {
        print(x);
        x++;
    }
}
