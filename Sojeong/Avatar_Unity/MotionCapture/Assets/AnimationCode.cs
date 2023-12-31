using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Threading;

public class AnimationCode : MonoBehaviour
{

    public GameObject[] Body;
    List<string> lines;
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        lines = System.IO.File.ReadLines("Assets/AnimationFile.txt").ToList();
    }

    // Update is called once per frame
    void Update()
    {
        // , 를 기준으로 좌표를 points 변수에 저장 
        string[] points = lines[counter].Split(',');

        // 랜드마크별 좌표를 구의 객체에 이식 
        for (int i=0; i<=32; i++)
        {
            float x = float.Parse(points[0+(i*3)]) / 100;
            float y = float.Parse(points[1 + (i * 3)]) / 100;
            float z = float.Parse(points[2 + (i * 3)]) / 100;
            Body[i].transform.localPosition = new Vector3(x, y, z);
        }

        counter += 1;
        // 랜드마크 별로 다 반복했을 경우 정지 
        if (counter == lines.Count) { counter = 0; }
        Thread.Sleep(30);
    }
}
