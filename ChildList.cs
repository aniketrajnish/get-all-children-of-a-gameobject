using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildList : MonoBehaviour
{
    public List<Transform> Children;
    // Start is called before the first frame update
    void Awake()
    {
        Children = new List<Transform>();
        GetRecursiveChildren(transform);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void GetRecursiveChildren(Transform parenttransform)
    {
        foreach (Transform child in parenttransform)
        {
            Children.Add(child.transform);
            if (child.transform.childCount > 0)
            {
                GetRecursiveChildren(child);
            }
        }
    }
}
