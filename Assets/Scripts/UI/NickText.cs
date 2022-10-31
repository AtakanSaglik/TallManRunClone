using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NickText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nickText;
    [SerializeField] private TMP_InputField nickDisplay;

    void Start()
    {
        nickText.text = PlayerPrefs.GetString("user_name");
    }

    public void Create()
    {
        nickText.text = nickDisplay.text;
        PlayerPrefs.SetString("user_name", nickText.text);
        PlayerPrefs.Save();

    }
}
