using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickedStartButton()
    {
        DataManager.instance.playerName = inputField.text;
        Debug.Log(inputField.text);
        SceneManager.LoadScene(1);
    }

    public void ClickedQuickButton()
    {
        Debug.Log("Quick");
    }

    public void PlayerName()
    {

    }
}
