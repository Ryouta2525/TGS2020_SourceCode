using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_On : MonoBehaviour
{
    public GameObject Ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void On()
    {
        Ui.SetActive(true);
    }

    public void off()
    {
        Ui.SetActive(false);
    }

   /* public void saveTuika()
    {
        AiconIre.AiconTime = PlayerPrefs.GetString("AiconTime");
        AiconIre.AiconTime2 = PlayerPrefs.GetString("AiconTime2");
        AiconIre.AiconTime3 = PlayerPrefs.GetString("AiconTime3");
    }*/
}
