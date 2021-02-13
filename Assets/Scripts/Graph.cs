﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{

    [SerializeField]
    Transform pointPrefab = default;

    [SerializeField, Range(10,100)]
    int resolution = 10;

    void Awake()
    {

        float step = 2f / resolution;
        Vector3 position = Vector3.zero;
		Vector3 scale = Vector3.one * step;
        

		for (int i = 0; i < resolution; i++) {

			Transform point = Instantiate(pointPrefab);

			position.x = (i + 0.5f) * step - 1f;
            position.y = Quadratic(position.x);
			point.localPosition = position;
			point.localScale = scale;

            point.SetParent(transform);

		}
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static float Quadratic(float x, float a=1, float b=0, float c=0)
    {
        return a*x*x + b*x + c;
    }


}

