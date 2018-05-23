using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progresser : MonoBehaviour
{

	private Material _material;
	private float _value;

	private void Start()
	{
		_material = GetComponent<MeshRenderer>().material;
	}

	private void Update()
	{
		_value += Time.deltaTime;
		if (_value > 1)
		{
			_value = 0;
		}
		_material.SetFloat("_Value", _value);
	}

}
