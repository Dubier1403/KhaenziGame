using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public Transform player;

    public Transform Far;
    public Transform Middle;

    private Vector2 ultimaPos;
    private Vector2 CantMover;
    void Start()
    {
        ultimaPos = transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);

        CantMover = new Vector2(transform.position.x - ultimaPos.x, transform.position.y - ultimaPos.y);

        Far.position += new Vector3(CantMover.x, CantMover.y, 0f);
        Middle.position += new Vector3(CantMover.x * .87f, CantMover.y * .87f, 0f);

        ultimaPos = transform.position;
    }
}
