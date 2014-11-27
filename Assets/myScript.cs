using UnityEngine;
using System.Collections;

public class myScript : MonoBehaviour {


	public Transform plane1;
	bool flag = true;
	// Use this for initialization
	void Start () {
	
	}



	// Update is called once per frame
	void Update () {

//				var plane = GameObject.Find ("Plane");
				var player = GameObject.Find ("First Person Controller");


				float PointPlane = this.transform.position.z + this.transform.localScale.z / 2;
				float playerZCoordinates = player.transform.position.z;
				
		//Debug.Log (PointPlane);
		//Debug.Log (playerZCoordinates);

		//Debug.Log (plane.transform.localPosition.z);
		//Debug.Log (plane.transform.localScale.z);
		//Debug.Log (player.transform.localPosition.z);
				if (playerZCoordinates > PointPlane && flag) {
					Instantiate(plane1,new Vector3(0,0,PointPlane),Quaternion.identity);	
					flag = false;		
				}


		}
}
