using UnityEngine;
using UnityEngine.UI;

public class InputFieldDemo : MonoBehaviour
{
    [SerializeField]
    InputField inputFieldObject;

    // Start is called before the first frame update
    void Start()
    {
        inputFieldObject.text = "Hello World";        
    }

    // Update is called once per frame
    void Update()
    {    
    }

    public void OnValueChanged() {
        Debug.Log("InputField value changed to " + inputFieldObject.text);
    }
}
