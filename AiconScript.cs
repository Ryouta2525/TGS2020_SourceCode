using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiconScript : MonoBehaviour
{
    public int MyNo;
    public static bool Aicon1,Aicon2,Aicon3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Serect1()
    {
        Aicon1 = true;
        Aicon2 = false;
        Aicon3 = false;
    }
    public void Serect2()
    {
        Aicon2 = true;
        Aicon1 = false;
        Aicon3 = false;
    }
    public void Serect3()
    {
        Aicon3 = true;
        Aicon2 = false;
        Aicon1 = false;
    }

    public void SerectAicon()
    {
        if (Aicon1)
        {
            GAMEMASTER.Aicon1No = MyNo;
            Debug.Log("qqq");
        }
        if (Aicon2)
        {
            GAMEMASTER.Aicon2No = MyNo;
        }
        if (Aicon3)
        {
            GAMEMASTER.Aicon3No = MyNo;
        }
    }
}
