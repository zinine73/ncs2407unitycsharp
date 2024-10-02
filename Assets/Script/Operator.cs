using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int answer = 0;

        int a = 10;
        answer = a++; // 이 문장을 실행하고 나서 ++ 을 해준다
        Debug.Log($"answer:{answer}, a:{a}");

        a = 10;
        answer = ++a; // 이 문장을 실행하기 전에 ++ 을 해준다
        Debug.Log($"answer:{answer}, a:{a}");

        a = 10;
        answer = +a; // a에 *1 을 한 후 answer에 넣는다
        Debug.Log($"answer:{answer}, a:{a}");

        a = 10;
        answer = -a; // a에 (-1)을 곱한 후 answer에 넣는다
        Debug.Log($"answer:{answer}, a:{a}");

        bool bt1 = true, bt2 = true, bf1 = false, bf2 = false; 
        Debug.Log((bt1 || bt2).ToString()); // 출력 : True  
        Debug.Log((bt1 || bf1).ToString()); // 출력 : True  
        Debug.Log((bf1 || bf2).ToString()); // 출력 : False 

        Debug.Log(typeof(int));
        int i = 1; 
        Debug.Log(i.GetType());

        Debug.Log(default(bool));

        // 연산자 우선순위를 알고 있어도, 읽기 쉽게 하기 위해 ()를 사용하자
        if ((a == 10) && (answer != 10))
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
