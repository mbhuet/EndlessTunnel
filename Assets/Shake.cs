﻿using UnityEngine;
using System.Collections;

public class Shake : MonoBehaviour {
	
	
	public bool Shaking; 
	private float ShakeDecay;
	private float ShakeIntensity;   
	private Vector3 OriginalPos;
	private Quaternion OriginalRot;
	
	void Start()
	{
		Shaking = false;   
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		if(ShakeIntensity > 0)
		{
			transform.position = OriginalPos + Random.insideUnitSphere * ShakeIntensity;
			transform.rotation = new Quaternion(OriginalRot.x + Random.Range(-ShakeIntensity, ShakeIntensity)*.2f,
			                                    OriginalRot.y + Random.Range(-ShakeIntensity, ShakeIntensity)*.2f,
			                                    OriginalRot.z + Random.Range(-ShakeIntensity, ShakeIntensity)*.2f,
			                                    OriginalRot.w + Random.Range(-ShakeIntensity, ShakeIntensity)*.2f);
			
			ShakeIntensity -= ShakeDecay;
		}
		else if (Shaking)
		{
			Shaking = false;  
		}
	}
	
	
	void OnGUI() {
		
		//if (GUI.Button(new Rect(10, 200, 50, 30), "Shake"))
		//	DoShake();
		//Debug.Log("Shake");
		
	}       
	
	
	
	
	
	
	public void DoShake()
	{
		OriginalPos = transform.position;
		OriginalRot = transform.rotation;
		
		ShakeIntensity = .01f;
		ShakeDecay = .1f;
		Shaking = true;
	}   
	
	
}