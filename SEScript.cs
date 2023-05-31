using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEScript : MonoBehaviour
{
    public AudioClip Don, Sutata, Gayan, GASYAN, Gayagaya, Hatena, Tyaimu, wwgayagaya, TuuwaHazimari, TuuwaOwari, Pistol, Batan, IntarHon;
    public AudioClip Pikon;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button()
    {
        source.PlayOneShot(Pikon);
    }
}
