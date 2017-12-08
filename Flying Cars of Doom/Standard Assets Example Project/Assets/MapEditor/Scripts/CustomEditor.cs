using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomEditor : MonoBehaviour {

    public Material[] materials;
    public GameObject materialButton;

    [SerializeField] Transform _buttonPanel;
    [SerializeField] Material _activeMaterial;


    private void Start()
    {
        foreach(Material material in materials)
        {
            GameObject button;
            button = Instantiate(materialButton, _buttonPanel);
            button.GetComponent<MaterialButton>().Init(material, this);
        }
    }

    public void SetActiveMaterial(Material material)
    {
        _activeMaterial = material;
    }

    void HandleInput()
    {
        Ray inputRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(inputRay, out hit))
        {
            GameObject objectClicked = hit.transform.gameObject;

            if (objectClicked.tag == "Cell")
            {
                Debug.Log("Cell Clicked");
                TouchCell(objectClicked.GetComponent<TerrainCell>());
            }
        }
    }

    void TouchCell(TerrainCell cell) // & changeColor == active
    {
        cell.SetMaterial(_activeMaterial);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            HandleInput();
        }
    }
}
