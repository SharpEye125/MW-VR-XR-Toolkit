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
        if((other.gameObject).tag != "Left Hand" && (other.gameObject).GetComponent<XRSocketInteractor>() == false || (other.gameObject).tag != "Right Hand" && (other.gameObject).GetComponent<XRSocketInteractor>() == false)
        {
            prefab = (other.gameObject);
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
