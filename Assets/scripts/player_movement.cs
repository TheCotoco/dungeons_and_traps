using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{

    private bool isMoving;
    private Vector3 origPos, targetPos, targetRot;
    public float timeToMove = 0.5f;
    public float speed = 0.01f;
    private Animation anim;
    private GameObject player;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        player = GameObject.Find("mago_player");
    }


    void Update()
    {

        if (Input.GetKey(KeyCode.W) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.forward));

        if (Input.GetKey(KeyCode.A) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.left));

        if (Input.GetKey(KeyCode.S) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.back));

        if (Input.GetKey(KeyCode.D) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.right));
    }

    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;
        Vector3 targetRot = new Vector3(0.0f, 0.0F, 0.0f);

        if (direction == Vector3.forward)
            targetRot = new Vector3(0.0f, 270.0f - player.transform.eulerAngles.y, 0.0f);
        if (direction == Vector3.right)
            targetRot = new Vector3(0.0f, 0.0f - player.transform.eulerAngles.y, 0.0f);
        if (direction == Vector3.left)
            targetRot = new Vector3(0.0f, 180.0f - player.transform.eulerAngles.y, 0.0f);
        if (direction == Vector3.back)
            targetRot = new Vector3(0.0f, 90.0f - player.transform.eulerAngles.y, 0.0f);


        float elapsedTime = 0;

        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        origPos = transform.position;
        targetPos = origPos + direction;

        player.transform.Rotate(targetRot, Space.Self);

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }


        isMoving = false;

    }


}

