using UnityEngine;
using System;
using System.Collections;
  
[RequireComponent(typeof(Animator))]  

public class IKControl : MonoBehaviour {
	
	protected Animator avatar;
	
	public bool ikActive = false;
	public Transform bodyObj = null;
	public Transform leftFootObj = null;
	public Transform rightFootObj = null;
	public Transform leftHandObj = null;
	public Transform rightHandObj = null;
	public Transform rightKnee = null;
	public Transform leftKnee = null;
	public Transform rightElbow = null;
	public Transform leftElbow = null;
	//public Transform lookAtObj = null;
	
	public float leftFootWeightPosition = 1;
	public float leftFootWeightRotation = 1;

	public float rightFootWeightPosition = 1;
	public float rightFootWeightRotation = 1;
	
	public float leftHandWeightPosition = 1;
	public float leftHandWeightRotation = 1;
	
	public float rightHandWeightPosition = 1;
	public float rightHandWeightRotation = 1;

	public float rightKneeWeightPosition = 1;

	public float leftKneeWeightPosition = 1;

	public float rightElbowWeightPosition = 1;

	public float leftElbowWeightPosition = 1;

	//public float lookAtWeight = 1.0f;
	
	// Use this for initialization
	void Start () 
	{
		avatar = GetComponent<Animator>();
	}

	void OnAnimatorIK(int layerIndex)
	{		
		if(avatar)
		{
			if(ikActive)
			{
				avatar.SetIKPositionWeight(AvatarIKGoal.LeftFoot,leftFootWeightPosition);
				avatar.SetIKRotationWeight(AvatarIKGoal.LeftFoot,leftFootWeightRotation);
							
				avatar.SetIKPositionWeight(AvatarIKGoal.RightFoot,rightFootWeightPosition);
				avatar.SetIKRotationWeight(AvatarIKGoal.RightFoot,rightFootWeightRotation);
	
				avatar.SetIKPositionWeight(AvatarIKGoal.LeftHand,leftHandWeightPosition);
				avatar.SetIKRotationWeight(AvatarIKGoal.LeftHand,leftHandWeightRotation);
							
				avatar.SetIKPositionWeight(AvatarIKGoal.RightHand,rightHandWeightPosition);
				avatar.SetIKRotationWeight(AvatarIKGoal.RightHand,rightHandWeightRotation);

				avatar.SetIKHintPositionWeight(AvatarIKHint.LeftKnee, leftKneeWeightPosition);

				avatar.SetIKHintPositionWeight(AvatarIKHint.RightKnee, rightKneeWeightPosition);

				avatar.SetIKHintPositionWeight(AvatarIKHint.LeftElbow, leftElbowWeightPosition);
				
				avatar.SetIKHintPositionWeight(AvatarIKHint.RightElbow, rightElbowWeightPosition);
				//avatar.SetLookAtWeight(lookAtWeight,0.3f,0.6f,1.0f,0.5f);
				
				if(bodyObj != null)
				{
					avatar.bodyPosition = bodyObj.position;
					avatar.bodyRotation = bodyObj.rotation;
				}				

				if(leftFootObj != null)
				{
					avatar.SetIKPosition(AvatarIKGoal.LeftFoot,leftFootObj.position);
					avatar.SetIKRotation(AvatarIKGoal.LeftFoot,leftFootObj.rotation);
				}				
			
				if(rightFootObj != null)
				{
					avatar.SetIKPosition(AvatarIKGoal.RightFoot,rightFootObj.position);
					avatar.SetIKRotation(AvatarIKGoal.RightFoot,rightFootObj.rotation);
				}				

				if(leftHandObj != null)
				{
					avatar.SetIKPosition(AvatarIKGoal.LeftHand,leftHandObj.position);
					avatar.SetIKRotation(AvatarIKGoal.LeftHand,leftHandObj.rotation);
				}				
			
				if(rightHandObj != null)
				{
					avatar.SetIKPosition(AvatarIKGoal.RightHand,rightHandObj.position);
					avatar.SetIKRotation(AvatarIKGoal.RightHand,rightHandObj.rotation);
				}

				if (leftKnee != null){
					avatar.SetIKHintPosition(AvatarIKHint.LeftKnee,leftKnee.position);
				}	
				if (rightKnee != null){
					avatar.SetIKHintPosition(AvatarIKHint.RightKnee,rightKnee.position);
				}
				if (leftElbow != null){
					avatar.SetIKHintPosition(AvatarIKHint.LeftElbow,leftElbow.position);
				}
				if (rightElbow != null){
					avatar.SetIKHintPosition(AvatarIKHint.RightElbow,rightElbow.position);
				}				
				/*
				if(lookAtObj != null)
				{
					avatar.SetLookAtPosition(lookAtObj.position);
				}	*/			
			}
			else
			{
				avatar.SetIKPositionWeight(AvatarIKGoal.LeftFoot,0);
				avatar.SetIKRotationWeight(AvatarIKGoal.LeftFoot,0);
							
				avatar.SetIKPositionWeight(AvatarIKGoal.RightFoot,0);
				avatar.SetIKRotationWeight(AvatarIKGoal.RightFoot,0);
	
				avatar.SetIKPositionWeight(AvatarIKGoal.LeftHand,0);
				avatar.SetIKRotationWeight(AvatarIKGoal.LeftHand,0);
							
				avatar.SetIKPositionWeight(AvatarIKGoal.RightHand,0);
				avatar.SetIKRotationWeight(AvatarIKGoal.RightHand,0);

				avatar.SetIKHintPositionWeight(AvatarIKHint.LeftKnee, 0);

				avatar.SetIKHintPositionWeight(AvatarIKHint.RightKnee, 0);

				avatar.SetIKHintPositionWeight(AvatarIKHint.LeftElbow, 0);
				
				avatar.SetIKHintPositionWeight(AvatarIKHint.RightElbow, 0);
				
				//avatar.SetLookAtWeight(0.0f);

				if(bodyObj != null)
				{
					bodyObj.position = avatar.bodyPosition;
					bodyObj.rotation = avatar.bodyRotation;
				}				
				
				if(leftFootObj != null)
				{
					leftFootObj.position = avatar.GetIKPosition(AvatarIKGoal.LeftFoot);
					leftFootObj.rotation  = avatar.GetIKRotation(AvatarIKGoal.LeftFoot);
				}				
				
				if(rightFootObj != null)
				{
					rightFootObj.position = avatar.GetIKPosition(AvatarIKGoal.RightFoot);
					rightFootObj.rotation  = avatar.GetIKRotation(AvatarIKGoal.RightFoot);
				}				
				
				if(leftHandObj != null)
				{
					leftHandObj.position = avatar.GetIKPosition(AvatarIKGoal.LeftHand);
					leftHandObj.rotation  = avatar.GetIKRotation(AvatarIKGoal.LeftHand);
				}				
				
				if(rightHandObj != null)
				{
					rightHandObj.position = avatar.GetIKPosition(AvatarIKGoal.RightHand);
					rightHandObj.rotation  = avatar.GetIKRotation(AvatarIKGoal.RightHand);
				}

				if (leftKnee != null){
					leftKnee.position = avatar.GetIKHintPosition(AvatarIKHint.LeftKnee);
				}	
				if (rightKnee != null){
					rightKnee.position = avatar.GetIKHintPosition(AvatarIKHint.RightKnee);
				}
				if (leftElbow != null){
					leftElbow.position = avatar.GetIKHintPosition(AvatarIKHint.LeftElbow);
				}
				if (rightElbow != null){
					rightElbow.position = avatar.GetIKHintPosition(AvatarIKHint.RightElbow);
				}					
				
				/*
				if(lookAtObj != null)
				{
					lookAtObj.position = avatar.bodyPosition + avatar.bodyRotation * new Vector3(0,0.5f,1);
				}	*/	
			}
		}
	}  
}
