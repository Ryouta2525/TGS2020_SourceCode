using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOGBotton : MonoBehaviour
{
    public GameObject Menu;
    private bool OnOff;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (OnOff)
        {
            Menu.SetActive(true);
        }
        else {
            Menu.SetActive(false);
        }

    }



    public void LogON()
    {
        OnOff = !OnOff;
    }
}
