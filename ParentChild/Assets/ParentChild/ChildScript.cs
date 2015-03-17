using UnityEngine;
using System.Collections;

public class ChildScript : MonoBehaviour {

	private GameObject _parent;

	void Start(){

		//親オブジェクトを取得
		_parent = transform.root.gameObject;

		Debug.Log ("Parent:" + _parent.name);

	}
}

