﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomStartAnim : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Animator anim = GetComponent<Animator> ();
		AnimatorStateInfo state = anim.GetCurrentAnimatorStateInfo (0);
		anim.Play (state.fullPathHash, -1, Random.Range(0f,1f));

	}

}
