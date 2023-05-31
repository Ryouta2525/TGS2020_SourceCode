using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitlSave : MonoBehaviour
{
    public static int Save;
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClik()
    {
        Save = i;
        SceneManager.LoadScene("MainScene");

    }

    public void Syokika()
    {
        GAMEMASTER.AiconOK1=false;
        GAMEMASTER.AiconOK2 = false;
        GAMEMASTER.AiconOK3 = false;
        GAMEMASTER.AiconOK4 = false;
        GAMEMASTER.AiconOK5 = false;
        GAMEMASTER.YosidaLove = 0;
        GAMEMASTER.SasaharaLove = 0;
        GAMEMASTER.TutiyaLove = 0;
        GAMEMASTER.MondouLove = 0;
    }
}
