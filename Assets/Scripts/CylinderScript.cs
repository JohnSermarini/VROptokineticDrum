using UnityEngine;

public class CylinderScript : MonoBehaviour
{
    private GameObject infoObject;
	private bool moving = false;
	private float turnSpeed = 30f;

    private void Start()
    {
        infoObject = GameObject.Find("Info");
    }

    private void Update () 
	{
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if(moving == false && Input.GetKey(KeyCode.Space))
        {
            infoObject.SetActive(false);
            moving = true;
        }
        else if(moving == true)
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
	}
}
