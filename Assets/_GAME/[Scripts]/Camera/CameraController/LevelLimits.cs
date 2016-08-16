﻿using UnityEngine;
using System.Collections;
/// <summary>
/// Add this class to a boxcollider to signify the bounds of your level
/// </summary>
public class LevelLimits : MonoBehaviour 
{
	/// left x coordinate
    [HideInInspector]
	public float LeftLimit;
	/// right x coordinate
    [HideInInspector]
	public float RightLimit;
	/// bottom y coordinate 
    [HideInInspector]
	public float BottomLimit;
	/// top y coordinate
    [HideInInspector]
	public float TopLimit;
	private BoxCollider2D _collider;
	
	/// <summary>
	/// On awake, fills the public variables with the level's limits
	/// </summary>
	void Awake () 
	{
		_collider=GetComponent<BoxCollider2D>();
		
		LeftLimit=_collider.bounds.min.x;
		RightLimit=_collider.bounds.max.x;
		BottomLimit=_collider.bounds.min.y;
		TopLimit=_collider.bounds.max.y;		
	}	
}