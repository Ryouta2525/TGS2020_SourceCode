using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingMemuScript : MonoBehaviour
{
    public GameObject Oto, SaveData;
    private bool oto, Savedata;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oto)
        {
            Oto.SetActive(true);
            SaveData.SetActive(false);
            Savedata = false;
        }
        if (Savedata)
        {
            SaveData.SetActive(true);
            Oto.SetActive(false);
            oto = false;
        }
    }

    public void otoOn()
    {
        Savedata = false;
        oto = true;
    }

    public void SavedataOn()
    {
        oto = false;
        Savedata = true;
    }
}
