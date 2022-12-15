using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class SampleSimpleInteractableFunc : MonoBehaviour
{
    public GameObject prefab;
    public GameObject defaultPrefab;
    public Transform spawnPoint;
    //public Collider itemSocket;
    //public bool useXRSockets = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if((gameObject).tag != "Left Hand" && (gameObject).GetComponent<XRSocketInteractor>() == false || (gameObject).tag != "Right Hand" && (gameObject).GetComponent<XRSocketInteractor>() == false)
        {
            prefab = (gameObject);
        }
        else
        {
            prefab = defaultPrefab;
        }
    }

    public void SpawnPrefab()
    {
        Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
    }
}
