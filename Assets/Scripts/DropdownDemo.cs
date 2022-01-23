using UnityEngine;
using UnityEngine.UI;

public class DropdownDemo : MonoBehaviour
{
    [SerializeField]
    Dropdown dropdown;

    void Start()
    {
        Debug.Log("Starting dropdown value: " + dropdown.options[dropdown.value].text);
    }

    void Update()
    {
    }

    public void OnValueChanged() {
        Debug.Log("Dropdown value: " + dropdown.options[dropdown.value].text);
    }

}
