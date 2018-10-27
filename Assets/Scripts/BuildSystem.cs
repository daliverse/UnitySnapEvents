using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSystem : MonoBehaviour
{
    public GameObject prefabToSpawn;

    public Material redMat;
    public Material greenMat;
    public Material blueMat;

    private Material currentMat;

    // Use this for initialization
    void Start()
    {
        currentMat = redMat;
    }

    public void SpawnPrefab()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            GameObject spawned = Instantiate(prefabToSpawn, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity);
            spawned.GetComponentInParent<MeshRenderer>().material = currentMat;
        }

    }

    public void ChooseMat(char c)
    {
        if (c == 'R') currentMat = redMat;
        else if (c == 'G') currentMat = greenMat;
        else if (c == 'B') currentMat = blueMat;
    }

}
