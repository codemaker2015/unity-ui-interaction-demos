using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AuthController : MonoBehaviour
{
    [SerializeField]
    InputField authCode;
    [SerializeField]
    Text info;

    private const int DELAY_TIME = 3;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Authenticate() {
        if(authCode.text == "hello2022")
            StartCoroutine(ShowInfo(info, "Authenticated",false));
        else if(authCode.text == "")
            StartCoroutine(ShowInfo(info, "Oops! Auth is empty",true));
        else
            StartCoroutine(ShowInfo(info, "Oops! Auth code error", true));
    }

    IEnumerator ShowInfo(Text info, string msg, bool err) {
        info.text = msg;
        if(err)
            info.GetComponent<Text>().color = Color.red;
        else
            info.GetComponent<Text>().color = Color.green;
        yield return new WaitForSeconds(DELAY_TIME);
        info.text = "";
        info.GetComponent<Text>().color = Color.white;
    }
}
