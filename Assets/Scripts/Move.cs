using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Hashtable args = new Hashtable();
		args.Add("easeType", iTween.EaseType.easeInOutExpo);
		args.Add("speed",1f);
		args.Add("delay", 0.0f);
		args.Add("loopType", "pingPong");
		args.Add("y",4.5f);
		iTween.MoveTo(gameObject,args);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
