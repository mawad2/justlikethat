using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void openNext (string nextGameObject){

		gameObject.SetActive (false);

		GameObject next = GameObject.Find (nextGameObject);
		Debug.Log (next);
		next.SetActive (true);

		return;
	}
}
