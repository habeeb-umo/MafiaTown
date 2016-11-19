﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	string[] tokenArray = new string[0];

	public void GetInput (string name){
		tokenArray = AddItemToArray (tokenArray, name);
		for(int i = 0; i < tokenArray.Length; i ++){
		Debug.Log (tokenArray[i]);
		}
		}
	public static string[] AddItemToArray(string[] original, string itemToAdd){

		string[] finalArray = new string[original.Length + 1];
		for(int i = 0; i < original.Length; i++){
			finalArray [i] = original [i];
		}

		finalArray [finalArray.Length - 1] = itemToAdd;
		return finalArray;

	}

} 

		

