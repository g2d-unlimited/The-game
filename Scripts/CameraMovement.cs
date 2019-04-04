using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Vector3 oldPosition;

    // Start is called before the first frame update
    void Start()
    {
        oldPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        CheckIfCameraMoved();
    }
    public void PanToHex(Hex hex)
    {

    }
    void CheckIfCameraMoved()
    {
        if(oldPosition != this.transform.position)
        {
            //smth moved camera
            oldPosition = this.transform.position;

            HexComponent[] hexComponents = GameObject.FindObjectsOfType<HexComponent>();

            foreach(HexComponent hex in hexComponents)
            {
                hex.UpdatePosition();
            }
        }
    }
}
