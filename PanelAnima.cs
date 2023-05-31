using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PanelAnima : MonoBehaviour
{
    private Animator anima;
    private TextController text;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Anten(TextController i) 
    {
            anima = this.gameObject.GetComponent<Animator>();
            anima.SetTrigger("Anten");
        text = i;
    }

    public void Seiten()
    {
        anima = this.gameObject.GetComponent<Animator>();
        text.TextUpdate();
    }

    public void hayaiAnten(TextController i)
    {
        anima = this.gameObject.GetComponent<Animator>();
        anima.SetTrigger("HayaiAnten");
        text = i;
    }

    public void Kakusi()
    {
        this.gameObject.SetActive(false);
    }

    public void Owaridayo()
    {
        anima = this.gameObject.GetComponent<Animator>();
        anima.SetTrigger("End");
    }

    public void end()
    {
        
        SceneManager.LoadScene("EndRool");
    }
}
