using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{

	[SerializeField]
	private List<Transform> path = new List<Transform>();
	[SerializeField]
	private float movespeed = 2f;
	[SerializeField]
	private bool looping = false;
	private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
		transform.position = path[index].transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
		Move();
    }
	private void Move()
	{
		while (index != path.Count)
		{
			transform.position = Vector2.MoveTowards(transform.position, path[index].transform.position, movespeed * Time.deltaTime);

			if(transform.position == path[index].transform.position)
			{
				index++;
			}
			else if (index == path.Count && looping == true) {
				index = 0;
			}
		}
	}
}


