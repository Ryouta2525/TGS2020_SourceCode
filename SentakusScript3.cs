using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SentakusScript3 : MonoBehaviour
{
    [SerializeField] Text utext;
    [SerializeField] [Multiline] string[] Sentakusis;
    AudioClip[] SentakuAudio;
    private string naiyou;
    private GameObject Oya;
    private int i;
    public GameObject maintext;
    private ScenarioScript scScript;
    private VoiseScript vcsc;
    private GameObject voiceObj;
    private GameObject scenarioOBJ;
    // Start is called before the first frame update
    void Start()
    {
        Oya = transform.parent.gameObject;
        scenarioOBJ = GameObject.Find("ScrnarioOBJ");
        voiceObj = GameObject.Find("VoiceOBJ");
        vcsc = voiceObj.GetComponent<VoiseScript>();
        scScript = scenarioOBJ.GetComponent<ScenarioScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GAMEMASTER.sentakusi == 13)
        {
            naiyou = "情報高得点";
            utext.text = naiyou + "";
            Sentakusis = scScript.Huyuyasumi01_4;
            SentakuAudio = vcsc.Huyuyasumi01_4;
        }
        if (GAMEMASTER.sentakusi == 14)
        {
            naiyou = "左下";
            utext.text = naiyou + "";
            Sentakusis = scScript.Sotugyou01_4;
            SentakuAudio = vcsc.Sotugyou01_4;
        }

    }

    public void Sentaku()
        {
        TextController controller = maintext.GetComponent<TextController>();
            controller.scenarios = Sentakusis;
        controller.Clips = SentakuAudio;
            controller.reset();
        }
}
