using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    public static SaveManager saveManager;
    public InputField usernameInput;
    public static string username;

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

}
