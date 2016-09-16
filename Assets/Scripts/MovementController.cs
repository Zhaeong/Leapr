using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {

    public GameObject playerObject;
    public GameObject MarkerObj;
    public float playerSpeed = 5.0f;

    private Camera MainCam;
    private RaycastHit hitInfo;
    private Vector3 StartPos;
    private bool MovingToPlat;
    private float LerpTime, LerpingTime;

    // Use this for initialization
    void Start () {
        MainCam = Camera.main;
        MovingToPlat = false;
    }
	
	// Update is called once per frame
	void Update () {

        //foreach(Touch touch in Input.touches)
        //{
        //    if(touch.phase == TouchPhase.Began)
        //    {
        //        Debug.Log("regist");
        //        playerObject.transform.position = MainCam.ScreenToWorldPoint(touch.position);
        //    }
        //}

        if (!MovingToPlat)
        {
            if (Input.GetMouseButtonDown(0))
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hitInfo, 100))
                {
                    
                    if (hitInfo.transform.gameObject.tag == "Platform")
                    {
                        MarkerObj.transform.position = new Vector3(hitInfo.point.x, hitInfo.point.y + 0.1f, hitInfo.point.z);
                        MarkerObj.transform.parent = hitInfo.transform;
                        StartPos = playerObject.transform.position;
                        playerObject.transform.parent = null;

                        MovingToPlat = true;
                        LerpTime = 0.0f;
                        LerpingTime = 0.0f;
                    }
                }
            }
        }

        if(MovingToPlat)
        {
            LerpingTime += Time.deltaTime * playerSpeed;
            if (LerpingTime > 1.0f)
            {
                LerpingTime = 1.0f;
                MovingToPlat = false;
                playerObject.transform.parent = hitInfo.transform;
            }
                
            playerObject.transform.position = Vector3.Lerp(StartPos, MarkerObj.transform.position, LerpingTime);

        }


    }
}
