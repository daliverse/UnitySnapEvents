using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour {

    public BuildSystem buildSystem;

    private void Awake()
    {
        buildSystem = GetComponent<BuildSystem>();
    }

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1)) buildSystem.SpawnPrefab();
        else if (Input.GetKeyDown(KeyCode.R)) buildSystem.ChooseMat('R');
        else if (Input.GetKeyDown(KeyCode.G)) buildSystem.ChooseMat('G');
        else if (Input.GetKeyDown(KeyCode.B)) buildSystem.ChooseMat('B');

    }
}
