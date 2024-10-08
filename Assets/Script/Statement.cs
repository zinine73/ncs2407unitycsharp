using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int val = 100, val2 = 1000;
        for (int i = 0; i < val; i++)
        {
            for (int j = 0; j < val2; j++)
            {
                
            }
        }
        string str = "sdhuidhwihie";
        foreach (var item in str)
        {
            Debug.Log(item);
        }

        while (val < 0)
        {
            // 실행이 안될수도 있다
        }

        do
        {
            // 반드시 한번 이상 실행된다

        } while (val < 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
