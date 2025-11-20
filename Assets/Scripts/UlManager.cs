using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIManager : MonoBehaviour
{
    [SerializeField]

    private TMP_Text notiText;

    public static UIManager instance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
    }
    public void ShowNotiText(string s)

    {

        notiText.text = s;


    }
}
