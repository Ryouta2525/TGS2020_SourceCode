using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiconKanri : MonoBehaviour
{
    public GameObject Aicon1, Aicon2, Aicon3, Aicon4, Aicon5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GAMEMASTER.AiconOK1)
        {
            Aicon1.SetActive(true);
        }
        else
        {
            Aicon1.SetActive(false);
        }
        if (GAMEMASTER.AiconOK2)
        {
            Aicon2.SetActive(true);
        }
        else
        {
            Aicon2.SetActive(false);
        }
        if (GAMEMASTER.AiconOK3)
        {
            Aicon3.SetActive(true);
        }
        else
        {
            Aicon3.SetActive(false);
        }
        if (GAMEMASTER.AiconOK4)
        {
            Aicon4.SetActive(true);
        }
        else
        {
            Aicon4.SetActive(false);
        }
        if (GAMEMASTER.AiconOK5)
        {
            Aicon5.SetActive(true);
        }
        else
        {
            Aicon5.SetActive(false);
        }

    }
}
