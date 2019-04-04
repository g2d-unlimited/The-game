using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject hexPrefab;
    public Material[] hexMaterials;

    public int numRows = 15;
    public int numColumns = 20;

    // Use this for initialization
    void Start()
    {
        GenerateMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GenerateMap()
    {
        for (int column = 0; column < numColumns; column++)
        {
            for (int row = 0; row < numRows; row++)
            {
                Hex hex = new Hex(column, row);
                GameObject hexGameObject = (GameObject)Instantiate(
                    hexPrefab,
                    hex.Position(),
                    Quaternion.identity,
                    this.transform);
                MeshRenderer meshRenderer = hexGameObject.GetComponentInChildren<MeshRenderer>();
                meshRenderer.material = hexMaterials[Random.Range(0, hexMaterials.Length)];
            }
        }
    }
}
