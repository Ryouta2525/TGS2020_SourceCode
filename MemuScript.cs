using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MemuScript : MonoBehaviour
{
    public GameObject OBJ;
    private bool o;
    // Start is called before the first frame update
    void Start()
    {
        OBJ.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            o = !o;
        }
        if (o)
        {
            OBJ.SetActive(true);
        }
        else
        {
            OBJ.SetActive(false);
        }
    }

    public void NO()
    {
        o = !o;
    }

    public void yameru()
    {

        Application.Quit();
    }
    public void TiTlHE()
    {
        SceneManager.LoadScene("Titl");
    }
}
