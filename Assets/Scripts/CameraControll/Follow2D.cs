using UnityEngine;
using System.Collections;

public class Follow2D : MonoBehaviour
{
    public GameObject target;
    public float distance;

    public void Update()
    {
        Vector3 pos = new Vector3(target.transform.position.x + 5F, target.transform.position.y, -distance);

        transform.position = Vector3.Lerp(transform.position, pos, 3.5f * Time.deltaTime);

        /*if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if(Camera.main.orthographicSize < 20)
                Camera.main.orthographicSize++;
        }
        else
        {
            if(Camera.main.orthographicSize > 5)
                Camera.main.orthographicSize--;
        }*/
        

    }
}
