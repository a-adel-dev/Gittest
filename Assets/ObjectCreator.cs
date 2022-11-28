using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    public GameObject objectPrefab;
    public Transform spawnLocation;
    public float force;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        GameObject spawnedObject = Instantiate(objectPrefab, spawnLocation.position, Quaternion.identity);
        spawnedObject.GetComponent<Rigidbody>().AddForce(spawnLocation.localEulerAngles * force, ForceMode.Impulse);
    }


}
