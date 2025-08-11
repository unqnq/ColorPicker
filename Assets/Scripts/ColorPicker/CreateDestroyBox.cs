using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDestroyBox : MonoBehaviour
{
    private Camera myCamera;
    [SerializeField] private int boxScale;
    [SerializeField] private GameObject cube;
    public ColorData colorData;
    public GameObject colorPickerPanel;

    void Awake()
    {
        myCamera = Camera.main;
        // colorPickerPanel = GameObject.Find("ColorPickerPanel");
    }

    void Update()
    {
        if (!colorPickerPanel.activeSelf)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SpawnBox();
            }
            if (Input.GetMouseButtonDown(1))
            {
                RaycastHit rHit;
                Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out rHit))
                {
                    GameObject temp = rHit.collider.gameObject;
                    if (temp.CompareTag("Cube"))
                    {
                        Destroy(temp);
                    }
                }
            }
        }

    }

    void SpawnBox()
    {
        RaycastHit rHit;
        Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out rHit))
        {
            int pointX = (int)rHit.point.x;
            int pointY = (int)rHit.point.y;
            int pointZ = (int)rHit.point.z;

            for (int x = pointX; x < pointX + boxScale; x++)
            {
                for (int y = pointY; y < pointY + boxScale; y++)
                {
                    for (int z = pointZ; z < pointZ + boxScale; z++)
                    {
                        GameObject temp = Instantiate(cube, new Vector3(x, y + cube.transform.localScale.y, z), Quaternion.identity);
                        temp.tag = "Cube";
                        temp.GetComponent<MeshRenderer>().material.color = colorData.currrentColor;
                    }
                }
            }
        }
    }
}
