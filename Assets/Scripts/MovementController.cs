using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {

    public GameObject playerObject;

    Camera MainCam;
	// Use this for initialization
	void Start () {
        MainCam = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {

        foreach(Touch touch in Input.touches)
        {
            if(touch.phase == TouchPhase.Began)
            {
                Debug.Log("regist");
                playerObject.transform.position = MainCam.ScreenToWorldPoint(touch.position);
            }
        }

        if(Input.GetMouseButton(0))
        {
            playerObject.transform.position = MainCam.ScreenToWorldPoint(Input.mousePosition);
        }
        

    }
}
