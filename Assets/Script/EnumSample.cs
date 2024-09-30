using System;
using UnityEngine;

public class EnumSample : MonoBehaviour
{
    enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    enum Month : byte { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };
    
    enum State //  
    {
        Ready,  // 
        Play,   //
        Gameover    //
    }

    [Flags]
    enum Days
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32
    }

    void Start()
    {
        Day day = Day.Monday;
        int dayNumber = (int)day; // cast 필요
        Debug.Log(dayNumber); 

        Month thisMonth = Month.Sep;
        byte monthNumber = (byte)thisMonth;
        int intNumber = (int)thisMonth; // 필요한 데이터형으로 cast
        Debug.Log(intNumber);
        Debug.Log($"{thisMonth} is month number #{monthNumber}.");

        State state = State.Ready;
        string nowState = state.ToString(); // string으로 형 변환
        Debug.Log(nowState);   

        Days workingDay = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;
        Debug.Log($"Working Days are {workingDay}");

        if ((workingDay & Days.Monday) == Days.Monday)
        {
            Debug.Log("Monday is working day");
        }
        else
        {
            Debug.Log("Monday is not working day");
        }
    }
}
