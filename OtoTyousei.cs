using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OtoTyousei : MonoBehaviour
{
    public static float BGM = 0.5f, SE=0.5f, VOICE=0.5f;
    public AudioSource BGMSo, SESo, VOICESo;
    public Slider BGMSl,SESl,VOICESl;
    // Start is called before the first frame update
    void Start()
    {
        BGMSl.normalizedValue = BGM;
        SESl.normalizedValue = SE;
        VOICESl.normalizedValue = VOICE;

        BGMSo.volume = BGM;
        SESo.volume = SE;
        VOICESo.volume = VOICE;
    }

    // Update is called once per frame
    void Update()
    {
        BGMSo.volume = BGMSl.normalizedValue;
        SESo.volume = SESl.normalizedValue;
        VOICESo.volume = VOICESl.normalizedValue;
        BGM = BGMSo.volume;
        SE = SESo.volume;
        VOICE = VOICESo.volume;
    }
}
