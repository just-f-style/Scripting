using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void Start()
    {
		Destroy(this.gameObject);
	}
}
