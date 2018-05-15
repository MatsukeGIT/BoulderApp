using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TransformObj : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler{
	private static int finger = -1;
	public Camera cam;
	public AvatarControl ac;
	private static string BODY_NAME = "CollisionBody";
	// Use this for initialization
	void Start () {
	}	
	

	public void OnBeginDrag(PointerEventData data){
		if (finger == -1){
			finger = data.pointerId;
			Debug.Log("name:"+gameObject.name);
		}
	}

	public void OnDrag(PointerEventData data){
		if (finger == data.pointerId){
			Vector3 p = cam.ScreenToWorldPoint(
				new Vector3(
					data.position.x, 
					data.position.y, 
					-cam.transform.position.z
				)
			);

			if (gameObject.name.Equals(BODY_NAME)){
				transform.position = new Vector3(p.x, p.y, ac.CalcBodyZPos(p));
			}else{
				transform.position = new Vector3(p.x, p.y, ac.CalcZPos(p));
			}
	    }
	}

	public void OnEndDrag(PointerEventData data){
		if (finger == data.pointerId){
			finger = -1;
		}
	}
}
