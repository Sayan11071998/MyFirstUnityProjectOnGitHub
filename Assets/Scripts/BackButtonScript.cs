using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButtonScript : MonoBehaviour
{
    public Button backButton;

    public string backButtonText;

    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick() {
        SceneManager.LoadScene(backButtonText);
    }

}
