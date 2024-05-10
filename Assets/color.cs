using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class color : MonoBehaviour
{
	
    public GameObject cube;
  

    private Color currentColor = new Color(0.0f, 0.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
       gameObject.GetComponent<Renderer>().material.color = currentColor;
    }

    // Update is called once per frame
    void Update()
    {
     
	if(Input.GetKeyDown(KeyCode.R))
	{
	  Debug.Log("Key pressed");
	  currentColor.r += 0.1f;
	  Debug.Log(currentColor.r);
          gameObject.GetComponent<Renderer>().material.color = currentColor;

	}   

	if(Input.GetKeyDown(KeyCode.E))
	{
	  Debug.Log("Key pressed");
	  currentColor.r -= 0.1f;
	  Debug.Log(currentColor.r);
          gameObject.GetComponent<Renderer>().material.color = currentColor;

	}   
    }
}
