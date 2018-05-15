using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HScene{
	private string[] onHolds;
	private List<string> comments;

	public HScene(){
		onHolds = new string[4];
		comments = new List<string>();
	}
	
	public string[] GetOnHolds(){
		return onHolds;
	}

	public void SaveOnHolds(Hold[] holds){
		for(int i = 0 ; i < onHolds.Length ; i++){
			if (holds[i] != null){
				onHolds[i] = holds[i].gameObject.name;
			}else{
				onHolds[i] = null;
			}
		}
	}

	public List<string> GetComments(){
		return new List<string>(comments);
	}

	public void SaveComments(List<string> com){
		comments = new List<string>(com);
	}
	
	public void show(){
		for(int i = 0 ; i < onHolds.Length ; i++){
			if (onHolds[i] != null){
				Debug.Log(i+":"+onHolds[i]);
			}
		}
	}
}
