﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	string[] nameArray = new string[0];
	string[] idArray = new string[0];

	int idArrLength, nameArrLength = 0;

	//Get Player Name input from Text Field
	public void GetNameInput (string name){
		nameArray = AddItemToArray (nameArray, name);
		Debug.Log (name + " will play!");
		this.nameArrLength = nameArray.Length;
		//Debug.Log (this.nameArrLength);
	}

	//Get Player ID input from Text Field
	public void GetIDInput (string id){
		idArray = AddItemToArray (idArray, id);
		Debug.Log (id + " assigned to player.");
		this.idArrLength = idArray.Length;
		//Debug.Log (this.idArrLength);
	}

	//Used to add any items to a string array
	public static string[] AddItemToArray(string[] original, string itemToAdd){
		string[] finalArray = new string[original.Length + 1];
		for(int i = 0; i < original.Length; i++){
			finalArray [i] = original [i];
		}

		finalArray [finalArray.Length - 1] = itemToAdd;
		return finalArray;

	}
		
//-------------------------------------------------------------------------------

	string[] mainRoles = {"MAFIA1", "MAFIA2", "COP", "DOCTOR"};

	public void AssignRoles(){
		if (idArrLength > 0) {
			string[] activeRoles = new string[idArrLength];
			for (int i = 0; i < idArrLength; i++) {
				activeRoles [i] = "VILLAGER";
			}
			//TODO: add randomizer element to replace activeRoles with mainRoles
			//activeRoles[Random] = mainRoles[i];
			for (int i = 0; i < activeRoles.Length; i = i + 2) {
				for(int j = 0; j < mainRoles.Length; j++){
					activeRoles [i] = mainRoles [j];
				}
			}
		} else
			Debug.Log ("No elements in ID Array");

	}

} 

		

