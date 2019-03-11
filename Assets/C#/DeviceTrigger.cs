using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceTrigger : MonoBehaviour {

    [SerializeField] private GameObject[] targets;

    public bool requirekey;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("enter");
        if(requirekey && Managers.Inventory.equippedItem != "key")
        {
            return;
        }

        foreach(GameObject target in targets)
        {
            target.SendMessage("Activate");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Exit");
        foreach (GameObject target in targets)
        {
            target.SendMessage("Deactivate");
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
