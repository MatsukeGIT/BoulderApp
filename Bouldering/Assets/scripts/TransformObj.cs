using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TransformObj : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler{
	private int finger;
	public Camera cam;
	// Use this for initialization
	void Start () {
	}	
	

	public void OnBeginDrag(PointerEventData data){
		if (finger == -1){
			finger = data.pointerId;
		}
	}

	public void OnDrag(PointerEventData data){
		if (finger != -1){
			/*
			Vector3 p = cam.ScreenToWorldPoint(
					new Vector3(
						data.position.x, 
						data.position.y, 
						-cam.transform.position.z));
				
			Vector3 oldP = cam.ScreenToWorldPoint(
					new Vector3(
						data.position.x - data.delta.x, 
						data.position.y - data.delta.y, 
						-cam.transform.position.z));

		    transform.Translate(p - oldP);*/
		    transform.position = cam.ScreenToWorldPoint(
				new Vector3(
					data.position.x, 
					data.position.y, 
					-cam.transform.position.z));
	    }
	}

	public void OnEndDrag(PointerEventData data){
		if (finger == data.pointerId){
			finger = -1;
		}
	}
}
