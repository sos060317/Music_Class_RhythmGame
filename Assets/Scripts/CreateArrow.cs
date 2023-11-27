using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateArrow : MonoBehaviour
{
    [SerializeField] private GameObject UparrowPrefab;
    [SerializeField] private GameObject DownarrowPrefab;
    [SerializeField] private GameObject LeftarrowPrefab;
    [SerializeField] private GameObject RightarrowPrefab;
    [SerializeField] private GameObject arrowParents;

    private void Update()
    {
        ArrowCreate();
    }

    private void ArrowCreate() 
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector2 pos = new Vector2(-3, 0);

            var arrow = Instantiate(UparrowPrefab, pos, Quaternion.Euler(0, 0, 90));

            arrow.transform.parent = arrowParents.transform;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector2 pos = new Vector2(1, 0);

            var arrow = Instantiate(DownarrowPrefab, pos, Quaternion.Euler(0, 0, -90));

            arrow.transform.parent = arrowParents.transform;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector2 pos = new Vector2(-1, 0);

            var arrow = Instantiate(LeftarrowPrefab, pos, Quaternion.Euler(0, 0, 180));

            arrow.transform.parent = arrowParents.transform;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector2 pos = new Vector2(3, 0);

            var arrow = Instantiate(RightarrowPrefab, pos, Quaternion.Euler(0, 0, 0));

            arrow.transform.parent = arrowParents.transform;
        }
    }

}
