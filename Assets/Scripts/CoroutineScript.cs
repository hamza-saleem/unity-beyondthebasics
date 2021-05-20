using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineScript : MonoBehaviour
{
    public List<Shape> gameShapes;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(SetShapesColor());
        }
    }

    private IEnumerator SetShapesColor()
    {
        foreach (Shape shape in gameShapes)
        {
            shape.SetColor(Color.blue);
            yield return new WaitForSeconds(2);
        }
    }
}
