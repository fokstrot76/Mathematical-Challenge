using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetInput : MonoBehaviour {

    private InputField input;
    private string nickname;
	// Use this for initialization
	void Start () {
        input = GetComponent<InputField>();
	}
	
    //settter and getter
	public void setNickName (InputField name) {
        nickname = name.text;
	}
    public string getNickName()
    {
        return nickname;
    }
}
