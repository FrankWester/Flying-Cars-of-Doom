using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[ExecuteInEditMode]
public class DrawGrid : MonoBehaviour {

    public TerrainCell cellPrefab;    //Set its size

    [SerializeField] Transform _cellTextHolder;
    [SerializeField] Transform _cellHolder;

    public Text cellLabelPrefab;

    Canvas _gridCanvas;

    public int width = 6;
    public int height = 6;

    TerrainCell[] cells;

    void Awake()
    {
        _gridCanvas = GetComponentInChildren<Canvas>();

        cells = new TerrainCell[height * width];

        for (int z = 0, i = 0; z < height; z++)
        {
            for (int x = 0; x < width; x++)
            {
                CreateCell(x, z, i++);
            }
        }
    }

    void CreateCell(int x, int z, int i)
    {
        Vector3 position;
        position.x = x * 10f;
        position.y = 0f;
        position.z = z * 10f;

        TerrainCell cell = cells[i] = Instantiate<TerrainCell>(cellPrefab);
        cell.transform.SetParent(_cellHolder, false);
        cell.transform.localPosition = position;

        cell.tag = "Cell";

        //Text label = Instantiate<Text>(cellLabelPrefab);
        //label.rectTransform.SetParent(_cellTextHolder, false);
        //label.rectTransform.anchoredPosition =
        //    new Vector2(position.x, position.z);
        //label.text = x.ToString() + "\n" + z.ToString();
    }

    void Update () {
		
	}
}
