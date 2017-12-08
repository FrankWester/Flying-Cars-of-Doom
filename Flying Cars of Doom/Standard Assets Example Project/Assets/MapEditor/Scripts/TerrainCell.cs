using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainCell : MonoBehaviour
{
    [SerializeField] Material material;
    MeshRenderer _meshRenderer;

    public void Start()
    {
        _meshRenderer = this.transform.gameObject.GetComponent<MeshRenderer>();

        material = _meshRenderer.material;
    }

    public void SetMaterial(Material newMaterial)
    {
        _meshRenderer.material = newMaterial;

    }
}
