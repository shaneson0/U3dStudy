using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputActor : MonoBehaviour {


    private InputField inputFiled;



	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("pass");
	}

    public void OnSubmit(string text)
    {
        Debug.Log("input text : " + text);
    }

    public void OnTestClick()
    {
        Debug.Log("click a button");
    }

}
