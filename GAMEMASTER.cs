using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMEMASTER : MonoBehaviour
{
    public static int sinkou,sentakusi,YosidaLove, SasaharaLove, MondouLove, TutiyaLove;
    public static string syuzinkou;
    public static bool Auto,AiconOK1,AiconOK2,AiconOK3,AiconOK4,AiconOK5;
    public static int Aicon1No, Aicon2No, Aicon3No;

    // Start is called before the first frame update
    void Start()
    {
        sentakusi = 0;
        sinkou = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
