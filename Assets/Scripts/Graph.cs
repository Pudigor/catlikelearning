using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Static;

namespace Graph
{
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
                position.y = Formulas.Quadratic(position.x);
                point.localPosition = position;
                point.localScale = scale;

                point.SetParent(transform, false);

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

    }
}

