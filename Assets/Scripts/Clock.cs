using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hourAngle, minuteAngle, secondAngle;

    void Update()
    {           ///DateTime=�q�����ɶ�
        Debug.Log( DateTime.Now ); ///�b�p�µ��L�N�N
        Debug.Log(DateTime.Now.Hour);
        int h = DateTime.Now.Hour;
        int s = DateTime.Now.Second;
        int m = DateTime.Now.Minute;
                               ///Quaternion:����AEuler(�ѩ�):���ਤ�ת����⤽��
        hourAngle.localRotation = Quaternion.Euler(0, 0, -30*h);
        secondAngle.localRotation = Quaternion.Euler(0, 0, -6*s);
        minuteAngle.localRotation = Quaternion.Euler(0, 0, -6*m);
        
    }
}
