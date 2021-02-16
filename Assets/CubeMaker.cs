using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMaker : MonoBehaviour
{
    public GameObject specialCubePrefab;
    List<GameObject> myPrefabs; // Declare

    // Start is called before the first frame update
    void Start()
    {
        myPrefabs = new List<GameObject>(); // Instantiate
        Vector3 location = Vector3.zero;
        Quaternion rotation = Quaternion.identity;
        for (int i = 0; i < 10; i++)
        {
            location.x = i * 10;
            myPrefabs.Add(Instantiate(specialCubePrefab, location, rotation));
        }
        Rigidbody rb = myPrefabs[4].GetComponent<Rigidbody>();
        rb.AddForce(rb.transform.forward * 5000.0f);
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 10; i++)
        {
            // Obtener Game Object 'i'
            GameObject go = myPrefabs[i];
            go.transform.Rotate(new Vector3(0, 0.1f, 0));
        }
    }


}
