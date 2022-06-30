using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hourAngle, minuteAngle, secondAngle;

    void Update()
    {           ///DateTime=電腦的時間
        Debug.Log( DateTime.Now ); ///在小黑窗印咚咚
        Debug.Log(DateTime.Now.Hour);
        int h = DateTime.Now.Hour;
        int s = DateTime.Now.Second;
        int m = DateTime.Now.Minute;
                               ///Quaternion:旋轉，Euler(由拉):旋轉角度的換算公式
        hourAngle.localRotation = Quaternion.Euler(0, 0, -30*h);
        secondAngle.localRotation = Quaternion.Euler(0, 0, -6*s);
        minuteAngle.localRotation = Quaternion.Euler(0, 0, -6*m);
        
    }
}
