using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class inputText : MonoBehaviour {

    ArrayList idArray = new ArrayList();
    ArrayList nameArray = new ArrayList();

    Text playerText;
	// Use this for initialization
	void Start () {

        playerText = GameObject.Find("InputName").GetComponent<Text>();

        nameArray.Add(playerText);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
