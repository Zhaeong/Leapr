using UnityEngine;
using System.Collections;

public class PlatformController : MonoBehaviour {

    public GameObject platformBasic;
    public Transform StartPos;
    public Transform EndPos;
    public float platSpeed = 5.0f;

    //Plat spawn speed in seconds
    public float spawnSpeed = 2.0f;
    
    private float stepSpeed = 0.0f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        stepSpeed += Time.deltaTime;
        int numBlocks = Random.Range(1, 4);

        if (stepSpeed > spawnSpeed)
        {
            for(int i = 0; i <= numBlocks; i++)
            {
                SpawnPlat(-10, 10, platSpeed);
            }
            //SpawnPlat(-10, 0, platSpeed);
            //SpawnPlat(1, 10, platSpeed);

            stepSpeed = 0.0f;

        }
        

    }

    void SpawnPlat(float SpawnLow, float SpawnHigh, float SpawnSpeed)
    {
        //Where the platform is spawned
        float varX = Random.Range(SpawnLow, SpawnHigh);
        //The dimensions of the platform
        float varWidth = Random.Range(5, 10);
        float varHeight = Random.Range(5, 10);

        Vector3 SpawnPos = new Vector3(varX, StartPos.position.y, StartPos.position.z);
        Vector3 SpawnEndPos = new Vector3(varX, EndPos.position.y, EndPos.position.z);
        GameObject Pla1 = (GameObject)Instantiate(platformBasic, SpawnPos, Quaternion.identity);

        Pla1.GetComponent<PlatformSpeed>().endPos = SpawnEndPos;
        Pla1.GetComponent<PlatformSpeed>().speed = SpawnSpeed;
        Pla1.transform.localScale = new Vector3(varWidth, 1, varHeight);

    }


}
