﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour {

	private static Singleton instance;
	
	public Draggable[] dgs;
	
	public static Singleton GetInstance{
		get{
			if(instance == null){
				instance = GameObject.FindObjectOfType<Singleton>();
			}

			return instance;
		}
	}
}
