using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    public static SaveManager saveManager;
    public InputField usernameInput;
    public static string username;
    public static int highscore = 0;

    // Start is called before the first frame update

    private void Awake()
    {
        if (saveManager != null)
        {
            Destroy(gameObject);
            return;
        }

        saveManager = this;
        DontDestroyOnLoad(gameObject);

    }

    public void GetUsername()
    {
        username = usernameInput.text;
    }

    private void Update()
    {
        
        Debug.Log(username);
    }


    public void SaveHighscore()
    {
         highscore = GameObject.Find("Main Manager").GetComponent<MainManager>().m_Points;
    }

}
