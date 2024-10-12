using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MyScript : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    
    public String Scene1;
    public String Scene2;
    public String Scene3;

    // Start is called before the first frame update
    void Start()
    {
        button1.onClick.AddListener(OnButtonClick_1);
        button2.onClick.AddListener(OnButtonClick_2);
        button3.onClick.AddListener(OnButtonClick_3);
    }

    private void OnButtonClick_1() {
        SceneManager.LoadScene(Scene1);
    }

    private void OnButtonClick_2() {
        SceneManager.LoadScene(Scene2);
    }

    private void OnButtonClick_3() {
        SceneManager.LoadScene(Scene3);
    }

}
