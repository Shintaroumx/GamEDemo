using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 裂星模式 : MonoBehaviour {

    // Use this for initialization
    public Vector3 _坐标偏差;
    public float _ForcePosDist = 1.0f;
    public float _冲击力大小=0.5f;
    Vector2 _冲击力;
    

    Rigidbody2D rb;
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        _冲击力 = Random.insideUnitCircle.normalized;
        rb.velocity = _冲击力 * _冲击力大小;

    }
	
	// Update is called once per frame
	void Update () {
       
	}
}
