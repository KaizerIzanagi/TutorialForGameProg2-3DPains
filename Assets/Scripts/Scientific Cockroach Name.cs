using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScientificCockroachName : MonoBehaviour
{
    public List<Color> color;
    public MeshRenderer meshRenderer;
    public float delayTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        /*for (int i = 0; i < color.Count; i++)
        {
            meshRenderer.material.color = color[Random.Range(0, 8)];
        }*/

    }
    
    // Runs when Enabled
    /*private void OnEnable()
    {
        for (int i = 0; i < color.Count; i++)
        {
            meshRenderer.material.color = color[Random.Range(0, 8)];
        }
    }
    */

    // The Opposite of above
    /*private void OnDisable()
    {
        for (int i = 0; i < color.Count; i++)
        {
            meshRenderer.material.color = color[Random.Range(0, 8)];
        }
    }
    */

    // Runs on Left Click
    private void OnMouseDown()
    {
        //Replaces the previously used code
        ChangeColor();
        //Repeats the Code used Once at set set interval (float value on the right)
        //Invoke("ChangeColor", delayTime);
        //Like Invoke, but repeating for x amount of time.
        InvokeRepeating("ChangeColor", 5, delayTime);
        //Cancels the current Invoke.
        //CancelInvoke();
    }
    

    // Runs when hovering over an object
    /*private void OnMouseEnter()
    {
        for (int i = 0; i < color.Count; i++)
        {
            meshRenderer.material.color = color[Random.Range(0, 8)];
        }
    }
    */

    // The Opposite of Above
    /*private void OnMouseExit()
    {
        for (int i = 0; i < color.Count; i++)
        {
            meshRenderer.material.color = color[Random.Range(0, 8)];
        }
    }
    */

    // The Inbetween of The Previous Two
    /*private void OnMouseOver()
    {
        for (int i = 0; i < color.Count; i++)
        {
            meshRenderer.material.color = color[Random.Range(0, 8)];
        }
    }
    */

    // Code Continues even after leaving object's collision box.
    /*private void OnMouseDrag()
    {
        for (int i = 0; i < color.Count; i++)
        {
            meshRenderer.material.color = color[Random.Range(0, 8)];
        }
    }
    */

    // Runs continuously after click. Same as, but is still the opposite of OnMouseDown
    /*private void OnMouseUpAsButton()
    {
        for (int i = 0; i < color.Count; i++)
        {
            meshRenderer.material.color = color[Random.Range(0, 8)];
        }
    }
    */

    // To Shorten your OnMouse(X)
    public void ChangeColor()
    {
        for (int i = 0; i < color.Count; i++)
        {
            meshRenderer.material.color = color[Random.Range(0, 8)];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Fixed Update is called 50 times per frame
    void FixedUpdate()
    {
        
    }
}
