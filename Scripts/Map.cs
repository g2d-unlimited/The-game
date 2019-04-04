using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject hexPrefab;
    public Material[] hexMaterials;

    const int mapHeight = 15;
    const int mapWidth = 20;

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
        for (int column = 0; column < mapWidth; column++)
        {
            for (int row = 0; row < mapHeight; row++)
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
