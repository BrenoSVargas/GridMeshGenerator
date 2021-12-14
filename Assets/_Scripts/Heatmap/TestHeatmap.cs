using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHeatmap : MonoBehaviour
{
    private void Start()
    {
        GridLogic grid = new GridLogic(20, 10, 5f, Vector3.zero);
    }
}
