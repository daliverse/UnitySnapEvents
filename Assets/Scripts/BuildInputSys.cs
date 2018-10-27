using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildInputSys : MonoBehaviour {

    public GameObject prefabToSpawn;

    public Material redMat;
    public Material greenMat;
    public Material blueMat;

    private Material currentMat;

    // Use this for initialization
    void Start () {
        currentMat = redMat;
	}
	
	// Update is called once per frame
	void Update () {
        

        if (Input.GetKeyDown(KeyCode.Alpha1)) SpawnPrefab();
        else if (Input.GetKeyDown(KeyCode.R)) currentMat = redMat;
        else if (Input.GetKeyDown(KeyCode.G)) currentMat = greenMat;
        else if (Input.GetKeyDown(KeyCode.B)) currentMat = blueMat;

    }

    public void SpawnPrefab()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            GameObject spawned = Instantiate(prefabToSpawn, new Vector3(hit.point.x, hit.point.y, hit.point.z), transform.rotation);
            spawned.GetComponentInParent<MeshRenderer>().material = currentMat;
        }

    }

}
