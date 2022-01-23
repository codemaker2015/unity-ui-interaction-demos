using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDemo : MonoBehaviour
{
    [SerializeField]
    Text txtMessage;

    // Start is called before the first frame update
    void Start()
    {
        txtMessage.text = "Hello World";        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
