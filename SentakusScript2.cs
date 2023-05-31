using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SentakusScript2 : MonoBehaviour
{
    [SerializeField] Text itext;
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
        if (GAMEMASTER.sentakusi == 6)
        {
            naiyou = "門藤先生(世界史)に質問する";
            Sentakusis = scScript.ZenkiSentaku_02_3;
            SentakuAudio = vcsc.ZenkiSentaku_02_3;
            itext.text = naiyou + "";
        }
        if (GAMEMASTER.sentakusi == 8)
        {
            naiyou = "笹原先生かな？";
            itext.text = naiyou + "";
            Sentakusis = scScript.Natuyasumi1_1_3;
            SentakuAudio = vcsc.Natuyasumi1_1_3;
        }
        if (GAMEMASTER.sentakusi == 10)
        {
            naiyou = "経理";
            TextController.Komakaino = 2;
            itext.text = naiyou + "";
            Sentakusis = scScript.Bunkasai01_3;
            SentakuAudio = vcsc.Bunkasai01_3;
        }
        if (GAMEMASTER.sentakusi == 13)
        {
            naiyou = "国語高得点";
            itext.text = naiyou + "";
            Sentakusis = scScript.Huyuyasumi01_3;
            SentakuAudio = vcsc.Huyuyasumi01_3;
        }
        if (GAMEMASTER.sentakusi == 14)
        {
            naiyou = "真ん中あたり";
            itext.text = naiyou + "";
            Sentakusis = scScript.Sotugyou01_3;
            SentakuAudio = vcsc.Sotugyou01_3;
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
