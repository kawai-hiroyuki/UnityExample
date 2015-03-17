using UnityEngine;
using System.Collections;

public class ParentChildrenScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int count = 0;
		foreach (Transform child in transform)
		{
			//child is your child transform

			Debug.Log ("Child[" + count + "]:" + child.name);
			count++;
		}
	
	}
}
